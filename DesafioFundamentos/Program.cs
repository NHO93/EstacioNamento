using DesafioFundamentos.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        decimal precoInicial = 0;
        decimal precoPorHora = 0;

        Console.WriteLine("Seja bem-vindo ao sistema de estacionamento!\nDigite o preço inicial:");

        if (decimal.TryParse(Console.ReadLine(), out precoInicial))
        {
            Console.WriteLine("Agora digite o preço por hora:");

            if (decimal.TryParse(Console.ReadLine(), out precoPorHora))
            {
                Estacionamento es = new Estacionamento(precoInicial, precoPorHora);

                // Carregar informações salvas, se houver
                es.CarregarVeiculos();

                string opcao = string.Empty;
                bool exibirMenu = true;

                while (exibirMenu)
                {
                    Console.Clear();
                    Console.WriteLine("Digite a sua opção:");
                    Console.WriteLine("1 - Cadastrar veículo");
                    Console.WriteLine("2 - Remover veículo");
                    Console.WriteLine("3 - Listar veículos");
                    Console.WriteLine("4 - Encerrar");

                    switch (Console.ReadLine())
                    {
                        case "1":
                            es.AdicionarVeiculo();
                            break;

                        case "2":
                            es.RemoverVeiculo();
                            break;

                        case "3":
                            es.ListarVeiculos();
                            break;

                        case "4":
                            // Salvar informações antes de encerrar
                            es.SalvarVeiculos();
                            exibirMenu = false;
                            break;

                        default:
                            Console.WriteLine("Opção inválida");
                            break;
                    }

                    Console.WriteLine("Pressione uma tecla para continuar...");
                    Console.ReadKey();
                }

                Console.WriteLine("O programa se encerrou");
            }
            else
            {
                Console.WriteLine("Valor inválido para preço por hora. O programa será encerrado.");
            }
        }
        else
        {
            Console.WriteLine("Valor inválido para preço inicial. O programa será encerrado.");
        }
    }
}
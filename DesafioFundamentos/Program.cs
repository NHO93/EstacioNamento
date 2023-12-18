using DesafioFundamentos.Models;

// Coloca o encoding para UTF8 para exibir acentuação
Console.OutputEncoding = System.Text.Encoding.UTF8;

decimal precoInicial = 0;
decimal precoPorHora = 0;

Console.WriteLine("Seja bem-vindo ao sistema de estacionamento!\nDigite o preço inicial:");

if (decimal.TryParse(Console.ReadLine(), out precoInicial) && precoInicial >= 0)
{
    Console.WriteLine("Agora digite o preço por hora:");

    if (decimal.TryParse(Console.ReadLine(), out precoPorHora) && precoPorHora >= 0)
    {
        // Instancia a classe Estacionamento, já com os valores obtidos anteriormente
        Estacionamento es = new Estacionamento(precoInicial, precoPorHora);
    }
    else
    {
        Console.WriteLine("Preço por hora inválido. O programa será encerrado.");
        return;
    }
}
else
{
    Console.WriteLine("Preço inicial inválido. O programa será encerrado.");
    return;
}
Console.WriteLine("Digite a sua opção:");
Console.WriteLine("1 - Cadastrar veículo");
Console.WriteLine("2 - Remover veículo");
Console.WriteLine("3 - Listar veículos");
Console.WriteLine("4 - Encerrar");
Console.Clear();

while (exibirMenu)
{
    Console.Clear();
    Console.WriteLine("Digite a sua opção:\n1 - Cadastrar veículo\n2 - Remover veículo\n3 - Listar veículos\n4 - Encerrar");

    string opcao = Console.ReadLine();

    switch (opcao)
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
            exibirMenu = false;
            break;

        default:
            Console.WriteLine("Opção inválida");
            break;
    }

    Console.WriteLine("Pressione uma tecla para continuar");
    Console.ReadLine();
}
Console.WriteLine("O programa foi encerrado com sucesso.");
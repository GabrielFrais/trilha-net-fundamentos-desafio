using DesafioFundamentos.Models;

// Coloca o encoding para UTF8 para exibir acentuação
Console.OutputEncoding = System.Text.Encoding.UTF8;

// Declarando variavéis
int option;
string? entrada;

Estacionamento estacionamento = new Estacionamento();

// Primeira interação
Console.Clear();
Console.WriteLine("Bem-vindo ao Sistema de Estacionamento!");

Console.WriteLine("Digite o preço inicial:");
entrada = Console.ReadLine();
decimal.TryParse(entrada, out estacionamento.preco_inicial);

Console.WriteLine("Digite o preço por hora:");
entrada = Console.ReadLine();
decimal.TryParse(entrada, out estacionamento.preco_hr);


entrada = null;
do
{
    Console.Clear();
    Console.WriteLine("Digite sua opção:\n1 - Cadastrar veículo\n2 - Remover veículo\n3 - Listar veículo\n4 - Encerrar");
    entrada = Console.ReadLine();
    int.TryParse(entrada, out option);

    switch (option)
    {
        case 1:
            estacionamento.Cadastrar();
            break;
        case 2:
            estacionamento.Remover();
            break;
        case 3:
            estacionamento.Listar_Veiculos();
            break;
        case 4:
            Console.WriteLine("\nVocê saiu do Sistema de Estacionamento!");
            break;
        default:
            Console.WriteLine("\nValor incorreto!\nPressione enter para tentar novamente.");
            Console.ReadLine();
            break;
    }
} while (option != 4);

//Screen Sound - curso da Alura: "C#:Criando sua primeira aplicação"
string mensagemDeBoasVindas = "\nBoas Vindas ao Screen Sound"; //aula 1
List<String> listaDasBandas = new List<string>();

void ExibirLogo() //aula 2
{
    Console.WriteLine(@"
█▀ █▀▀ █▀█ █▀▀ █▀▀ █▄░█   █▀ █▀█ █░█ █▄░█ █▀▄
▄█ █▄▄ █▀▄ ██▄ ██▄ █░▀█   ▄█ █▄█ █▄█ █░▀█ █▄▀"); //Exibição personalisada
    Console.WriteLine(mensagemDeBoasVindas);
}

void ExibirOpcoesMenu()
{
    ExibirLogo();
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a média de uma banda");
    Console.WriteLine("Digite 0 para sair");

    Console.Write("\nDigite a sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNume = int.Parse(opcaoEscolhida); // Converte de string para int

    switch (opcaoEscolhidaNume)
    {
        case 1:
            RegistrarBanda();
            break;
        case 2:
            MostrarBandasRegistradas();
            break;
        case 3:
            Console.WriteLine("Você escolheu a opção " + opcaoEscolhidaNume);
            break;
        case 4:
            Console.WriteLine("Você escolheu a opção " + opcaoEscolhidaNume);
            break;
        case 0:
            Console.WriteLine("Até logo");
            break;
        default:
            Console.WriteLine("Opção Inavlida");
            break;
    }
}

void RegistrarBanda() //aula 3
{
    Console.Clear();
    Console.WriteLine("Registro de Bandas");
    Console.Write(" \nDigite o nome da banda para registar: ");
    string nomeDaBanda = Console.ReadLine()!;
    listaDasBandas.Add(nomeDaBanda);
    Console.WriteLine($"A banda {nomeDaBanda} foi registrada");
    Thread.Sleep(2000);
    Console.Clear();
    ExibirOpcoesMenu();

}
void MostrarBandasRegistradas()
{
    Console.Clear();
    Console.WriteLine("Exibindo as bandas registradas\n");
    // for (int i = 0; i < listaDasBandas.Count; i++)
    // {
    //     Console.WriteLine($"Banda:{listaDasBandas[i]}");
    // }
    foreach (string banda in listaDasBandas)
    {
        Console.WriteLine($"Banda:{banda}");
    }

    Console.WriteLine("\nDigite uma tecla para voltar ao menu");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesMenu();
}

ExibirOpcoesMenu();


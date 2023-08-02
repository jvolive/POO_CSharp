//Screen Sound
string mensagemDeBoasVindas = "Boas Vindas ao Screen Sound"; //aula 1

void ExibirMensagemDeBoasVindas() //aula 2
{
    Console.WriteLine(@"🆂🅲🆁🅴🅴🅽 🆂🅾🆄🅽🅳");
    Console.WriteLine(mensagemDeBoasVindas);
}

void ExibirOpcoesMenu()
{
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
            Console.WriteLine("Você escolheu a opção " + opcaoEscolhidaNume);
            break;
        case 2:
            Console.WriteLine("Você escolheu a opção " + opcaoEscolhidaNume);
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

ExibirMensagemDeBoasVindas();
ExibirOpcoesMenu();


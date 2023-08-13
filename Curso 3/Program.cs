﻿using ScreenSound.menu;
using ScreenSound.Models;

Banda iron = new Banda("Iron Maiden");
iron.AdicionarNota(new Avaliacao(10));
iron.AdicionarNota(new Avaliacao(9));
iron.AdicionarNota(new Avaliacao(10));

Dictionary<string, Banda> bandasRegistradas = new();
bandasRegistradas.Add(iron.Nome, iron);

Dictionary<int, Menu> opcoes = new();
opcoes.Add(1, new MenuRegistrarBanda());
opcoes.Add(2, new MenuRegistrarAlbum());
opcoes.Add(3, new MenuMostrarBandasRegistradas());
opcoes.Add(4, new MenuAvaliarBanda());
opcoes.Add(5, new MenuExibirDetalhes());
opcoes.Add(0, new Menu0());



void ExibirLogo()
{
    Console.WriteLine(@"

░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
");
    Console.WriteLine("Boas vindas ao Screen Sound 2.0!");
}

void ExibirOpcoesDoMenu()
{
    ExibirLogo();
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para registrar o álbum de uma banda");
    Console.WriteLine("Digite 3 para mostrar todas as bandas");
    Console.WriteLine("Digite 4 para avaliar uma banda");
    Console.WriteLine("Digite 5 para exibir os detalhes de uma banda");
    Console.WriteLine("Digite 0 para sair");

    Console.Write("\nDigite a sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    if (opcoes.ContainsKey(opcaoEscolhidaNumerica))
    {
        Menu menuASerExibido = opcoes[opcaoEscolhidaNumerica];
        menuASerExibido.Executar(bandasRegistradas);
        if (opcaoEscolhidaNumerica > 0) ExibirOpcoesDoMenu();
    }
    else
    {
        Console.WriteLine("Opção inválida");
    }

    // switch (opcaoEscolhidaNumerica)
    // {
    //     case 1:
    //         MenuRegistrarBanda menu1 = new();
    //         menu1.Executar(bandasRegistradas);
    //         ExibirOpcoesDoMenu();
    //         break;
    //     case 2:
    //         MenuRegistrarAlbum menu2 = new();
    //         menu2.Executar(bandasRegistradas);
    //         ExibirOpcoesDoMenu();
    //         break;
    //     case 3:
    //         MenuMostrarBandasRegistradas menu3 = new();
    //         menu3.Executar(bandasRegistradas);
    //         ExibirOpcoesDoMenu();
    //         break;
    //     case 4:
    //         MenuAvaliarBanda menu4 = new();
    //         menu4.Executar(bandasRegistradas);
    //         ExibirOpcoesDoMenu();
    //         break;
    //     case 5:
    //         MenuExibirDetalhes menu5 = new MenuExibirDetalhes();
    //         menu5.Executar(bandasRegistradas);
    //         ExibirOpcoesDoMenu();
    //         break;
    //     case 0:
    //         Menu0 menu6 = new();
    //         menu6.Executar(bandasRegistradas);
    //         break;
    //     default:
    //         Console.WriteLine("Opção inválida");
    //         ExibirOpcoesDoMenu();
    //         break;
    // }
}
ExibirOpcoesDoMenu();
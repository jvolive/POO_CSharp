using ScreenSound.Models;
using OpenAI_API;

namespace ScreenSound.menu;

internal class MenuRegistrarBanda : Menu
{
    internal override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        base.Executar(bandasRegistradas);
        ExibirTituloDaOpcao("Registro das bandas");
        Console.Write("Digite o nome da banda que deseja registrar: ");
        string nomeDaBanda = Console.ReadLine()!;
        Banda banda = new Banda(nomeDaBanda);
        bandasRegistradas.Add(nomeDaBanda, banda);

        var client = new OpenAIAPI("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");

        var chat = client.Chat.CreateConversation();

        chat.AppendSystemMessage($"Resuma a banda {nomeDaBanda} em 1 paragrafo. Adote um estilo informal.");

        string resposta = chat.GetResponseFromChatbotAsync().GetAwaiter().GetResult();
        banda.Resumo = resposta;

        Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso!");
        Console.WriteLine("Digite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();

    }
}


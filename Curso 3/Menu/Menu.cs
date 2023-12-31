using ScreenSound.Models;

namespace ScreenSound.menu;

internal class Menu
{
    internal void ExibirTituloDaOpcao(string titulo)
    {
        int quantidadeDeLetras = titulo.Length;
        string asteriscos = string.Empty.PadLeft(quantidadeDeLetras, '*');
        Console.WriteLine(asteriscos);
        Console.WriteLine(titulo);
        Console.WriteLine(asteriscos + "\n");
    }

    internal virtual void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        Console.Clear();
    }
}

using ScreenSound.Models;

namespace ScreenSound.menu;

public interface IAvaliavel
{
    void AdicionarNota(Avaliacao nota);
    double Media { get; }
}

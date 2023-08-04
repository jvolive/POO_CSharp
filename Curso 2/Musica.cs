class Musica //aula 1
{
    public string Nome { get; set; }
    public string Artista { get; set; }
    public int Duracao { get; set; }
    public bool Disponivel { get; set; } //aula 2
    public string DescricaoResumida => $"A musica {Nome} pertence a {Artista}"; // Lambda

    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Artista: {Artista}");
        Console.WriteLine($"Duração: {Duracao}");
        if (Disponivel)
        {
            Console.WriteLine("Disponivel no plano.");
        }
        else
        {
            Console.WriteLine("Adquira o plano Plus+");
        }


    }
}

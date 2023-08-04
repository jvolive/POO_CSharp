// Banda ironMaiden = new Banda("Iron Maiden");

// Album albumDoIron = new Album("Fear of the Dark");

// Musica musica1 = new Musica(ironMaiden, "Childhood's End")
// {
//     Duracao = 280,
//     Disponivel = true,
// };

// Musica musica2 = new Musica(ironMaiden, "Fear of the dark")
// {
//     Duracao = 438,
//     Disponivel = false,
// };

// albumDoIron.AdicionarMusica(musica1);
// albumDoIron.AdicionarMusica(musica2);
// ironMaiden.AdicionarAlbum(albumDoIron);

// musica1.ExibirFichaTecnica();
// musica2.ExibirFichaTecnica();
// albumDoIron.ExibirMusicasDoAlbum();
// ironMaiden.ExibirDiscografia();

Episodio ep1 = new(1, "God of war", 60);

ep1.AdicionarConvidados("João");
ep1.AdicionarConvidados("Rebeca");
Console.WriteLine(ep1.Resumo);

Episodio ep2 = new(2, "BF1", 65);

ep2.AdicionarConvidados("João");
ep2.AdicionarConvidados("Rebeca");
ep2.AdicionarConvidados("Marcos");

Podcast podcast = new("Podcast PS4", "João");
podcast.AdicionarEpisodio(ep1);
podcast.AdicionarEpisodio(ep2);
podcast.ExibirDetalhes();
Banda ironMaiden = new Banda("Iron Maiden");

Album albumDoIron = new Album("Fear of the Dark");

Musica musica1 = new Musica(ironMaiden, "Childhood's End")
{
    Duracao = 280,
    Disponivel = true,
};

Musica musica2 = new Musica(ironMaiden, "Fear of the dark")
{
    Duracao = 438,
    Disponivel = false,
};

albumDoIron.AdicionarMusica(musica1);
albumDoIron.AdicionarMusica(musica2);
ironMaiden.AdicionarAlbum(albumDoIron);

musica1.ExibirFichaTecnica();
musica2.ExibirFichaTecnica();
albumDoIron.ExibirMusicasDoAlbum();
ironMaiden.ExibirDiscografia();
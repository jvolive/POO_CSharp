Album albumDoIron = new Album();
albumDoIron.Nome = "Fear of the Dark";

Musica musica1 = new Musica();
musica1.Nome = "Childhood's End";
musica1.Duracao = 280;

Musica musica2 = new Musica();
musica2.Nome = "Fear of the dark";
musica2.Duracao = 438;

albumDoIron.AdicionarMusica(musica1);
albumDoIron.AdicionarMusica(musica2);

albumDoIron.ExibirMusicasDoAlbum();
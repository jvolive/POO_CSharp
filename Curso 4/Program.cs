using System.Text.Json;
using Curso_4.Filter;
using Curso_4.Model;

using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;

        LinqFilter.FiltrarMusicasEmCSharp(musicas);

        // musicas[2].ExibirDetalhesDaMusica();
        // LinqFilter.FiltrarTodosOsGEnerosMusicais(musicas);
        // LinqFilter.FiltrarArtistasPorGeneroMusical(musicas, "rock");
        // LinqFilter.FiltrarMusicasDeUmArtista(musicas, "Red Hot Chili Peppers");
        // LinqOrder.ExibirListaDeArtistasOrdenados(musicas);

        // var MusicasPreferidasDoJoao = new MusicasPreferidas("Joao");
        // MusicasPreferidasDoJoao.AdicionarMusicasFavoritas(musicas[1]);
        // MusicasPreferidasDoJoao.AdicionarMusicasFavoritas(musicas[4]);
        // MusicasPreferidasDoJoao.AdicionarMusicasFavoritas(musicas[23]);
        // MusicasPreferidasDoJoao.AdicionarMusicasFavoritas(musicas[13]);
        // MusicasPreferidasDoJoao.AdicionarMusicasFavoritas(musicas[456]);

        // MusicasPreferidasDoJoao.ExibirMusicasFavoritas();
        // MusicasPreferidasDoJoao.GerarArquivoJson();
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Temos um problema: {ex.Message}");
    }

}
using System.Text.Json;

namespace Curso_4.Model
{
    public class MusicasPreferidas
    {
        public string Nome { get; set; }
        public List<Musica> ListaDeMusicasFavoridas { get; }

        public MusicasPreferidas(string nome)
        {
            Nome = nome;
            ListaDeMusicasFavoridas = new List<Musica>();
        }

        public void AdicionarMusicasFavoritas(Musica musica)
        {
            ListaDeMusicasFavoridas.Add(musica);
        }

        public void ExibirMusicasFavoritas()
        {
            Console.WriteLine($"Essas sao as musicas favoridas {Nome}");
            foreach (var musica in ListaDeMusicasFavoridas)
            {
                Console.WriteLine($" - {musica.Nome} de {musica.Artista}");
            }
        }

        public void GerarArquivoJson()
        {
            string json = JsonSerializer.Serialize(new
            {
                nome = Nome,
                musicas = ListaDeMusicasFavoridas
            });
            string nomeDoArquivo = $"musicas-favoridas-{Nome}.json";
            File.WriteAllText(nomeDoArquivo, json);
            Console.WriteLine($"O arquivo Json salvo com sucesso!{Path.GetFullPath(nomeDoArquivo)}");
        }
    }



}
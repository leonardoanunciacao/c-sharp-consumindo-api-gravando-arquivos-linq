using System.Text.Json;
using c_sharp_consumindo_api_gravando_arquivos_linq.Modelos;
using c_sharp_consumindo_api_gravando_arquivos_linq.Filtros;

using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        //Console.WriteLine(resposta);
        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;
        // musicas[0].ExibirDetalhesDaMusica();

        LinqFilter.FiltrarMusicasNoTom(musicas, "C#");

        // LinqFilter.FiltrarTodosOsGenerosMusicais(musicas);
        // LinqOrder.ExibirListaDeArtistasOrdenados(musicas);
        // LinqFilter.FiltrarArtistasPorGeneroMusical(musicas, "pop");
        //LinqFilter.FiltrarMusicasPorArtista(musicas, "Michel Teló");

        // var musicasPreferidasDaniel = new MusicasPreferidas("Daniel");
        // musicasPreferidasDaniel.AdicionarMusicasFavoritas(musicas[1]);
        // musicasPreferidasDaniel.AdicionarMusicasFavoritas(musicas[377]);
        // musicasPreferidasDaniel.AdicionarMusicasFavoritas(musicas[4]);
        // musicasPreferidasDaniel.AdicionarMusicasFavoritas(musicas[6]);
        // musicasPreferidasDaniel.AdicionarMusicasFavoritas(musicas[1467]);

        // musicasPreferidasDaniel.ExibirMusicasFavoritas();

        // musicasPreferidasDaniel.GerarArquivoJson();

    }
    catch (System.Exception ex)
    {
        Console.WriteLine($"Ocorreu um problema: {ex.Message}");
    }
}
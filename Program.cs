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
        // LinqFilter.FiltrarTodosOsGenerosMusicais(musicas);
        // LinqOrder.ExibirListaDeArtistasOrdenados(musicas);
        // LinqFilter.FiltrarArtistasPorGeneroMusical(musicas, "pop");
        LinqFilter.FiltrarMusicasPorArtista(musicas, "Michel Teló");

    }
    catch (System.Exception ex)
    {
        Console.WriteLine($"Ocorreu um problema: {ex.Message}");
    }
}
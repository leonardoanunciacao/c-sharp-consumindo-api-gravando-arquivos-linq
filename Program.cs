using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.jso");
        Console.WriteLine(resposta);
    }
    catch (System.Exception ex)
    {
        Console.WriteLine($"Ocorreu um problema: {ex.Message}");
    }
}
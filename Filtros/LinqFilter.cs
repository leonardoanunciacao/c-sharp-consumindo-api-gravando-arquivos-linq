using c_sharp_consumindo_api_gravando_arquivos_linq.Modelos;

namespace c_sharp_consumindo_api_gravando_arquivos_linq.Filtros
{
    internal class LinqFilter
    {
        public static void FiltrarTodosOsGenerosMusicais(List<Musica> musicas)
        {
            var todosOsGenerosMusicais = musicas.Select(generos => generos.Genero).Distinct().ToList();
            foreach (var genero in todosOsGenerosMusicais){
                Console.WriteLine($"- {genero}");
            }
        }

        public static void FiltrarArtistasPorGeneroMusical(List<Musica> musicas, string genero)
        {
            var artistaPorGeneroMusical = musicas.Where(musica => musica.Genero!.Contains(genero)).Select(musica => musica.Artista).Distinct().ToList();
            Console.WriteLine($"Exibindo os artistas por gênero musical >>> {genero}");
            foreach (var artista in artistaPorGeneroMusical)
            {
                Console.WriteLine($"{artista}");
            }
        }

        public static void FiltrarMusicasPorArtista(List<Musica> musicas, string artista)
        {
            var musicasPorArtista = musicas.Where(musica => musica.Artista!.Contains(artista)).Select(musica => musica.Nome).Distinct().ToList();
            foreach(var musica in musicasPorArtista)
            {
                Console.WriteLine($"- {musica}");
            }
        }    

        public static void FiltrarMusicasDeUmArtista(List<Musica> musicas, string nomeDoArtista)
        {
            var musicasDoArtista = musicas.Where(musica => musica.Artista!.Equals(nomeDoArtista)).ToList();
            Console.WriteLine(nomeDoArtista);
            foreach (var musica in musicasDoArtista)
            {
                Console.WriteLine($"- {musica.Nome}");
            }
        }

        internal static void FiltrarMusicasNoTom(List<Musica> musicas, string tonalidade)
        {
            var musicasNoTom = musicas
                .Where(musica => musica.Tonalidade.Equals(tonalidade))
                .Select(musica => musica.Nome)
                .ToList();
            Console.WriteLine($"Musicas em {tonalidade}");
            foreach (var musica in musicasNoTom)
            {
                Console.WriteLine($"- {musica}");
            }
        }
    }
}
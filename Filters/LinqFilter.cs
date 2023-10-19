using music_box4.Models;

namespace music_box4.Filters;

public class LinqFilter
{
    public static void FilterAllMusicGenres(List<Music> musics)
    {
        var allMusicGenres = musics.Select(music => music.Genre).Distinct().ToList();
        foreach (var genre in allMusicGenres)
        {
            Console.WriteLine($"- {genre}");
        }
    }

    public static void FilterArtistsByGenre(List<Music> musics, string genre)
    {
        var artistsByGenre = musics.Where(music => music.Genre!.Contains(genre)).Select(music => music.Artist).Distinct().ToList();
        Console.WriteLine($"Display artists by music genre => {genre}");
        foreach (var artist in artistsByGenre)
        {
            Console.WriteLine($"- {artist}");
        }
    }

    public static void FilterMusicsByArtist(List<Music> musics, string artist)
    {
        var musicsOfArtist = musics.Where(music => music.Artist!.Equals(artist)).ToList();
        Console.WriteLine($"All music of artist => {artist}");
        foreach (var music in musicsOfArtist)
        {
            Console.WriteLine($"- {music.Name}");
        }
    }

    public static void FilterMusicsByYear(List<Music> musics, int year)
    {
        var musicsByYear = musics.Where(music => music.Year! == year).OrderBy(music => music.Name).Select(music => music.Name).Distinct().ToList();
        Console.WriteLine($"The musics of year => {year}");
        foreach (var music in musicsByYear)
        {
            Console.WriteLine($"- {music}");
        }
    }
}
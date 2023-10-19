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
}
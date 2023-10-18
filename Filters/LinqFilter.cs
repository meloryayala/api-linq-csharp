using music_box4.Models;

namespace music_box4.Filters;

public class LinqFilter
{
    public static void FilterAllMusicGenres(List<Music> musics)
    {
        var allMusicGenres = musics.Select(genres => genres.Genre).Distinct().ToList();
        foreach (var genre in allMusicGenres)
        {
            Console.WriteLine($"- {genre}");
        }
    }
}
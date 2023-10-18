using music_box4.Models;

namespace music_box4.Filters;

public class LinqOrder
{
    public static void DisplayArtistList(List<Music> musics)
    {
        var artistsOrdered = musics.OrderBy(music => music.Artist).Select(music => music.Artist).Distinct().ToList();
        Console.WriteLine("List of ordered artists");
        foreach (var artist in artistsOrdered)
        {
            Console.WriteLine($"- {artist}");
        }
    }
}
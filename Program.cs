using System.Text.Json;
using music_box4.Filters;
using music_box4.Models;

using (HttpClient client = new HttpClient())
{
    try
    {
        string response = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        var musics = JsonSerializer.Deserialize<List<Music>>(response)!;
        LinqFilter.FilterAllMusicGenres(musics);
    }
    catch (Exception e)
    {
        Console.WriteLine($"We have a problem {e}");
    }
}

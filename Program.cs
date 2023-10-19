using System.Text.Json;
using music_box4.Filters;
using music_box4.Models;

using (HttpClient client = new HttpClient())
{
    try
    {
        string response = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        var musics = JsonSerializer.Deserialize<List<Music>>(response)!;
        // LinqFilter.FilterAllMusicGenres(musics);
        // LinqOrder.DisplayArtistList(musics);
        // LinqFilter.FilterArtistsByGenre(musics, "pop");
        // LinqFilter.FilterArtistsByGenre(musics, "country");
        // LinqFilter.FilterMusicsByArtist(musics, "Shakira");
        // LinqFilter.FilterMusicsByYear(musics, 2000);

        // var favoriteMusicsAna = new FavoriteMusics("Ana");
        // favoriteMusicsAna.AddFavoriteMusics(musics[5]);
        // favoriteMusicsAna.AddFavoriteMusics(musics[6]);
        // favoriteMusicsAna.AddFavoriteMusics(musics[7]);
        // favoriteMusicsAna.AddFavoriteMusics(musics[8]);
        // favoriteMusicsAna.AddFavoriteMusics(musics[9]);
        //
        // favoriteMusicsAna.DisplayFavoriteMusics();

        var favoriteMusicsPaul = new FavoriteMusics("Paul");
        favoriteMusicsPaul.AddFavoriteMusics(musics[800]);
        favoriteMusicsPaul.AddFavoriteMusics(musics[801]);
        favoriteMusicsPaul.AddFavoriteMusics(musics[802]);
        favoriteMusicsPaul.AddFavoriteMusics(musics[804]);
        favoriteMusicsPaul.AddFavoriteMusics(musics[805]);
        
        favoriteMusicsPaul.DisplayFavoriteMusics();
        favoriteMusicsPaul.GenerateJsonFile();
        favoriteMusicsPaul.GenerateTxtFile();
        

    }
    catch (Exception e)
    {
        Console.WriteLine($"We have a problem {e}");
    }
}

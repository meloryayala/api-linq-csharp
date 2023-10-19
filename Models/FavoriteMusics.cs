using System.Text.Json;

namespace music_box4.Models;

public class FavoriteMusics
{
    public string? Name { get; set; }
    public List<Music> ListFavoriteMusics { get; set; }

    public FavoriteMusics(string name)
    {
        Name = name;
        ListFavoriteMusics = new List<Music>();
    }

    public void AddFavoriteMusics(Music music)
    {
        ListFavoriteMusics.Add(music);
    }

    public void DisplayFavoriteMusics()
    {
        Console.WriteLine($"\nAll favorite musics of => {Name}\n");
        foreach (var favoriteMusic in ListFavoriteMusics)
        {
            Console.WriteLine($"- {favoriteMusic.Name} of {favoriteMusic.Artist}");
        }
    }

    public void GenerateJsonFile()
    {
        string json = JsonSerializer.Serialize(new
        {
            name = Name,
            musics = ListFavoriteMusics,
        });
        string fileName = $"favorite-musics-{Name}.json";
        File.WriteAllText(fileName, json);
        Console.WriteLine($"\nThe file {fileName} was created successfully {Path.GetFullPath(fileName)}!");
    }

    public void GenerateTxtFile()
    {
        string fileName = $"favorite-musics-{Name}";
        using (StreamWriter txtFile = new StreamWriter(fileName))
        {
            txtFile.WriteLine($"Favorite musics of {Name}\n");
            foreach (var favoriteMusic in ListFavoriteMusics)
            {
                txtFile.WriteLine($"- {favoriteMusic.Name}");
            }
        }

        Console.WriteLine($"Text file {fileName} generated successfully {Path.GetFullPath(fileName)}!");
    }
}
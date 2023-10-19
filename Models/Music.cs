using System.Text.Json.Serialization;

namespace music_box4.Models;

public class Music
{
    [JsonPropertyName("song")]
    public string? Name { get; set; }
    [JsonPropertyName("artist")]
    public string? Artist { get; set; }
    
    [JsonPropertyName("duration_ms")]
    public int? Duration { get; set; }
    [JsonPropertyName("genre")]
    public string? Genre { get; set; }
    [JsonPropertyName("year")]
    public string? YearString { get; set; }

    public int? Year => int.Parse(YearString);

    public void DisplayMusicDetails()
    {
        Console.WriteLine($"Artist: {Artist}");
        Console.WriteLine($"Music: {Name}");
        Console.WriteLine($"Duration: {Duration /1000}s");
        Console.WriteLine($"Genre: {Genre}");
    }
}
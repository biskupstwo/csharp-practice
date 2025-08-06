namespace csharp_practice.exercises.Playlist;

public class Song
{
    private string _title;
    private double _duration;

    public Song(string title, double duration)
    {
        _title = title;
        _duration = duration >= 0 ? duration : 0;
    }
    
    public string GetTitle() => _title;

    public override string ToString()
    {
        return $"{_title}: {_duration}";
    }
}
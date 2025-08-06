namespace csharp_practice.exercises.Playlist;

public class Album
{
    private string _name;
    private string _artist;
    private List<Song> _songs;

    public Album(string name, string artist)
    {
        _name = name;
        _artist = artist;
        _songs = new List<Song>();
    }

    public bool AddSong(string title, double duration)
    {
        Song song = new Song(title, duration);
        _songs.Add(song);
        return _songs.Contains(song);
    }

    public Song? FindSong(string title)
    {
        Song? song = null;

        for (int i = 0; i < _songs.Count; i++)
        {
            if (_songs[i].GetTitle() == title)
            {
                song = _songs[i];
                break;
            }
        }

        return song;
    }

    public bool AddToPlayList(int trackNumber, LinkedList<Song> playlist)
    {
        int index = trackNumber - 1;
        if (index < 0 || index >= _songs.Count) return false;
        Song song = _songs[index];
        playlist.AddLast(song);
        return playlist.Contains(song);
    }

    public bool AddToPlayList(string title, LinkedList<Song> playlist)
    {
        Song? song = FindSong(title);
        if (song == null) return false;
        playlist.AddLast(song);
        return playlist.Contains(song);
    }
}
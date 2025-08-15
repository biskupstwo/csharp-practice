namespace csharp_practice.exercises.Playlist;

public class Album
{
    private string _name;
    private string _artist;
    private SongList _songs;

    public class SongList
    {
        private List<Song> _songList;

        public SongList(List<Song> songList)
        {
            _songList = songList;
        }
        
        public bool Add(string title, double duration)
        {
            if (FindSong(title) != null) return false;
            Song song = new Song(title, duration);
            _songList.Add(song);
            return true;
        }
        
        public Song? FindSong(string title)
        {
            Song? song = null;

            for (int i = 0; i < _songList.Count; i++)
            {
                if (_songList[i].GetTitle() == title)
                {
                    song = _songList[i];
                    break;
                }
            }

            return song;
        }

        public Song? FindSong(int trackNumber) => trackNumber <= 0 || trackNumber > _songList.Count ? null : _songList[trackNumber-1];

    }
    public Album(string name, string artist)
    {
        _name = name;
        _artist = artist;
        _songs = new SongList(new List<Song>());
    }

    public bool AddSong(string title, double duration) => _songs.Add(title, duration);
    public Song? FindSong(string title) => _songs.FindSong(title);
    public Song? FindSong(int trackNumber) => _songs.FindSong(trackNumber);
    
    
    public bool AddToPlayList(int trackNumber, LinkedList<Song> playlist)
    {
        Song? song = FindSong(trackNumber);
        if (song == null) return false;
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
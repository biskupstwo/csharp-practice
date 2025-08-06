namespace csharp_practice.exercises.Playlist;

public class PlaylistPlayground
{
    public static void Playground()
    {
        List<Album> albums = new List<Album>();
	 
        Album album = new Album("Stormbringer", "Deep Purple");
        album.AddSong("Stormbringer", 4.6);
        album.AddSong("Love don't mean a thing", 4.22);
        album.AddSong("Holy man", 4.3);
        album.AddSong("Hold on", 5.6);
        album.AddSong("Lady double dealer", 3.21);
        album.AddSong("You can't do it right", 6.23);
        album.AddSong("High ball shooter", 4.27);
        album.AddSong("The gypsy", 4.2);
        album.AddSong("Soldier of fortune", 3.13);
        albums.Add(album);
	 
        album = new Album("For those about to rock", "AC/DC");
        album.AddSong("For those about to rock", 5.44);
        album.AddSong("I put the finger on you", 3.25);
        album.AddSong("Lets go", 3.45);
        album.AddSong("Inject the venom", 3.33);
        album.AddSong("Snowballed", 4.51);
        album.AddSong("Evil walks", 3.45);
        album.AddSong("C.O.D.", 5.25);
        album.AddSong("Breaking the rules", 5.32);
        album.AddSong("Night of the long knives", 5.12);
        albums.Add(album);
	 
        LinkedList<Song> playList = new LinkedList<Song>();
        albums[0].AddToPlayList("You can't do it right", playList);
        albums[0].AddToPlayList("Holy man", playList);
        albums[0].AddToPlayList("Speed king", playList);  // Does not exist
        albums[0].AddToPlayList(9, playList);
        albums[1].AddToPlayList(3, playList);
        albums[1].AddToPlayList(2, playList);
        albums[1].AddToPlayList(24, playList);  // There is no track 24
    }
}
namespace NeoBeat_Net.Models.Song;
using NeoBeat_Net.Models.Artist;
public class Song
{
    
    #region Attributes
    
    public string IdSong { get; set; }
    public string Name { get; set; }
    public int Duration {get; set;}
    public Artist? Artist { get; set; }
    // media mp3?
    public string SongImage { get; set; } = "https://static.vecteezy.com/system/resources/previews/002/249/673/non_2x/music-note-icon-song-melody-tune-flat-symbol-free-vector.jpg";
    public bool IsFavorite { get; set; }
    #endregion
    
    #region Constructors

    // Empty 
    #region EmptyConstructor

    public Song()
    {   
        this.Name = string.Empty;
        this.Artist = null;
        this.Duration = 0;
    }

    #endregion
    
    // Full 
    #region FullConstructor

    public Song(string name, Artist artist, int duration)
    {
        this.Name = name;
        this.Artist = artist;
        this.Duration = duration;
    }

    #endregion
    
    // SemiFull constructor: string name, int duration
    #region SemiFullConstructor

    public Song(string name, int duration)
    {   
        this.Name = name;
        this.Duration = duration;
    }

    #endregion
    
    #endregion
    
}
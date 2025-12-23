namespace NeoBeat_Net.Models.PlayList;
using NeoBeat_Net.Models.Song;

public class PlayList
{   
    
    #region Attributes
    
    public string IdPlayList { get; set; }
    public string Name { get; set; }
    public List<Song> Songs { get; set; }
    public string Size { get; set; } = "0";
    public string PlayListImage {get; set;} = "https://i1.sndcdn.com/avatars-wpOz0Tqdl3eoO4WM-O3P1Qw-t1080x1080.jpg";
    
    #endregion
    
    #region Constructors

    // Empty 
    #region EmptyConstructor

    public PlayList()
    {
        this.IdPlayList = string.Empty;
        this.Name = string.Empty;
        this.Songs = [];
    }

    #endregion
    
    // Full
    #region FullConstructor

    public PlayList(string name, List<Song> songs)
    {
        this.IdPlayList = string.Empty;
        this.Name = name;
        this.Songs = songs;
    }

    #endregion
    
    // SemiFullConstructor: string name
    #region SemiFullConstructor
    
    public PlayList(string name)
    {
        this.IdPlayList = string.Empty;
        this.Name = name;
        this.Songs = [];
        this.Size = Songs.Count.ToString();
    }
    
    #endregion
    
    #endregion
    
    #region Methods
    
    // Add song
    #region AddSong
    public void AddSong(Song song)
    {
        Songs.Add(song);
    }
    #endregion
    
    // Delete Song
    #region RemoveSong
    public void DeleteSong(Song song)
    {
        if (!Songs.Contains(song))
        {
            AddSong(song);
        }
        Songs.Remove(song);
    } 
    #endregion
    
    #endregion
    
}
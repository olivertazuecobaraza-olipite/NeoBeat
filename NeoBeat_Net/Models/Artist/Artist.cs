namespace NeoBeat_Net.Models.Artist;
using NeoBeat_Net.Models.User;
using NeoBeat_Net.Models.Song;

public class Artist : NeoUser
{
    
    #region Attributes
    
    public string IdArtist {get; set;}
    public string ArtisticName { get; set; }
    public List<Song> Songs { get; set; }
    
    #endregion
    
    #region Constructors

    // Empty
    #region EmtyConstructor

    public Artist()
    {
        this.IdArtist = string.Empty;
        this.ArtisticName = string.Empty;
        this.Songs = [];
    }

    #endregion
    
    // Full
    #region FullConstructor
    
    public Artist(string name, List<Song> songs)
    {
        this.IdArtist = string.Empty;
        this.ArtisticName = name;
        this.Songs = songs;
    }
    
    #endregion
    
    // SemiFullConstructor
    #region SemiFullConstructor

    public Artist(string name)
    {
        this.IdArtist = string.Empty;
        this.ArtisticName = name;
        this.Songs = [];
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
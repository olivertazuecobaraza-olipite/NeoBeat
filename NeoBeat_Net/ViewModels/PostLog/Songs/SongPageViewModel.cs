using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using NeoBeat_Net.Models.Song;

namespace NeoBeat_Net.ViewModels.PostLog.Songs;

using Models.PlayList;

public partial class SongPageViewModel : ObservableObject
{
    #region Observables

    [ObservableProperty] private PlayList _playlist;

    #endregion

    #region Constructor

    public SongPageViewModel()
    {

        Playlist = new PlayList("nombre playlist"); // tiene que pasarse como parametro
        
        // datos de prueba
        Playlist.AddSong(new Song("cancion 1", 123));
        Playlist.AddSong(new Song("cancion 1",321));
        Playlist.AddSong(new Song("cancion 1",123));
        Playlist.AddSong(new Song("cancion 1",123));
    }

    #endregion
    
    #region Commands

    [RelayCommand]
    private void TapSong()
    {
        
    }
    
    #endregion
    
}
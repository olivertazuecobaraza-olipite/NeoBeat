using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Firebase.Auth;
using NeoBeat_Net.Models.Artist;
using NeoBeat_Net.Models.Song;
using NeoBeat_Net.Pages.PostLog.Songs;
using NeoBeat_Net.Services.FireBase_Authentication;
using NeoBeat_Net.Shell.PreLog;


namespace NeoBeat_Net.ViewModels.PostLog.Profile;
using NeoBeat_Net.Models.PlayList;
using Microsoft.Maui.Controls;

public partial class ProfilePageViewModel : ObservableObject
{

    private readonly FireBaseAuth _fbaAuth;
    
    [ObservableProperty] private Song _song = new Song("Cancion Fav", 123);
    [ObservableProperty] private PlayList _playList = new PlayList("Lista Cancion");

    public ProfilePageViewModel(FireBaseAuth fba)
    {
        _fbaAuth = fba;

        Song.Artist = new Artist("Artista prueba");
        Song.Artist.ArtisticName = "Artistic Name";
    }
    
    

    
    #region Commands

    [RelayCommand]
    private async Task TapPlaylist()
    {
        await Shell.Current.GoToAsync(nameof(SongsPage));
    }

    #endregion
}
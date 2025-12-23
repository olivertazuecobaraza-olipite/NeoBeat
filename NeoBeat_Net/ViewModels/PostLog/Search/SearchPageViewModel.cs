using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using NeoBeat_Net.Pages.PostLog.Songs;

namespace NeoBeat_Net.ViewModels.PostLog.Search;
using Microsoft.Maui.Controls;
using Models.PlayList;
public partial class SearchPageViewModel : ObservableObject
{
    #region Observables

    [ObservableProperty] private PlayList _pl = new PlayList();
    [ObservableProperty] private ObservableCollection<PlayList> _recommended = [];
    [ObservableProperty] private ObservableCollection<PlayList> _genres = [];

    #endregion
    

    #region Contructor
    
    public SearchPageViewModel()
    {
        SetRecommended();
        SetGenres();
    }
    
    #endregion

    #region Commands

    [RelayCommand]
    private async Task TapPlaylist()
    {
        await Shell.Current.GoToAsync(nameof(SongsPage), true);
    }

    #endregion
    
    #region Methods
    
    private void SetRecommended()
    {
        Recommended.Add(new PlayList("Lista1"));
        Recommended.Add(new PlayList("Lista2"));
        Recommended.Add(new PlayList("Lista3"));
        Recommended.Add(new PlayList("Lista4"));
        Recommended.Add(new PlayList("Lista5"));
        Recommended.Add(new PlayList("Lista6"));
    }
    
    private void SetGenres()
    {
        Genres.Add(new PlayList("Lista1"));
        Genres.Add(new PlayList("Lista2"));
        Genres.Add(new PlayList("Lista3"));
        Genres.Add(new PlayList("Lista4"));
        Genres.Add(new PlayList("Lista5"));
        Genres.Add(new PlayList("Lista6"));
    }
    
    #endregion
    
}
using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using NeoBeat_Net.Pages.PostLog.Songs;

namespace NeoBeat_Net.ViewModels.PostLog.PlayList;
using Microsoft.Maui.Controls;

using NeoBeat_Net.Models.PlayList;
public partial class PlayListPageViewModel : ObservableObject
{
    [ObservableProperty] private ObservableCollection<PlayList> _listas = [];

    public PlayListPageViewModel()
    {
        Listas.Add(new PlayList("Lista1"));
        Listas.Add(new PlayList("Lista2"));
        Listas.Add(new PlayList("Lista3"));
        Listas.Add(new PlayList("Lista4"));
        
        
    }
    
    
    #region Listas
    
    [RelayCommand]
    private async Task TapPlaylist()
    {
        await Shell.Current.GoToAsync(nameof(SongsPage));
    }

    [RelayCommand]
    private void DeletePlayList(PlayList playList)
    {
        if (Listas.Contains(playList)) Listas.Remove(playList);
    }
    #endregion
}
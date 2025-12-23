using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NeoBeat_Net.ViewModels.PostLog.PlayList;

namespace NeoBeat_Net.Pages.PostLog.Playlist;

public partial class PlayListPage : ContentPage
{
    public PlayListPage(PlayListPageViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}
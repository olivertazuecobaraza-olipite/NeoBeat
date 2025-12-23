using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NeoBeat_Net.ViewModels.PostLog.PlayList;
using NeoBeat_Net.ViewModels.PostLog.Songs;

namespace NeoBeat_Net.Pages.PostLog.Songs;

public partial class SongsPage : ContentPage
{
    public SongsPage(SongPageViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NeoBeat_Net.ViewModels.PostLog.Search;

namespace NeoBeat_Net.Pages.PostLog.Search;

public partial class SearchPage : ContentPage
{
    public SearchPage(SearchPageViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}
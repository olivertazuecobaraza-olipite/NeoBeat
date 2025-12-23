using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NeoBeat_Net.ViewModels.PostLog.Settings;

namespace NeoBeat_Net.Pages.PostLog.Settings;

public partial class SettingsPage : ContentPage
{
    public SettingsPage(SettingsPageViewModel viewmodel)
    {
        InitializeComponent();
        BindingContext = viewmodel;
    }
}
using NeoBeat_Net.Pages.PostLog.Songs;

namespace NeoBeat_Net.Shell.PostLog;
using Microsoft.Maui.Controls;

public partial class AppShellPost : Shell
{
    public AppShellPost()
    {
        InitializeComponent();
        
        // routes
        Routing.RegisterRoute(nameof(SongsPage), typeof(SongsPage));
    }
}
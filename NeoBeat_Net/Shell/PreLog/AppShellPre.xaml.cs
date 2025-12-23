using NeoBeat_Net.Pages.PreLog.Register;

namespace NeoBeat_Net.Shell.PreLog;
using Microsoft.Maui.Controls;

public partial class AppShellPre : Shell
{
    public AppShellPre()
    {
        InitializeComponent();
        
        // routes
        Routing.RegisterRoute(nameof(RegisterPage), typeof(RegisterPage));
        
    }
}
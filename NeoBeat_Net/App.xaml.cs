using NeoBeat_Net.Shell.PreLog;
using NeoBeat_Net.Shell.PostLog;
namespace NeoBeat_Net;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();
    }

    protected override Window CreateWindow(IActivationState? activationState)
    {
        return new Window(new AppShellPre());
    }
}
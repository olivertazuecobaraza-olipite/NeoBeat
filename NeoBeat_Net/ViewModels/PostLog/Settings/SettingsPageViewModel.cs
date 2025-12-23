using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using NeoBeat_Net.Services.FireBase_Authentication;
using NeoBeat_Net.Shell.PreLog;

namespace NeoBeat_Net.ViewModels.PostLog.Settings;

public partial class SettingsPageViewModel(FireBaseAuth fba) : ObservableObject
{
    #region Observables

    [ObservableProperty] private bool _isDarkTheme = Application.Current!.RequestedTheme == AppTheme.Dark;

    #endregion

    #region Commands

    #region Cerrar Sesion

    [RelayCommand]
    private void Cerrar()
    {
        fba.LogOutAsync();
        Application.Current!.Windows[0].Page = new AppShellPre();
    }

    #endregion

    #endregion

    #region methods

    #region Cambiar Theme

    partial void OnIsDarkThemeChanged(bool value)
    {
        Application.Current!.UserAppTheme = value ? AppTheme.Dark : AppTheme.Light;
    }


    #endregion

    #endregion
}

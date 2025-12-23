using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Maui.Core;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using NeoBeat_Net.Pages.PreLog.Register;
using NeoBeat_Net.Services.FireBase_Authentication;
using NeoBeat_Net.Shell.PostLog;

namespace NeoBeat_Net.ViewModels.PreLog.Login;
using Microsoft.Maui.Controls;
public partial class LoginPageViewModel(FireBaseAuth fba) : ObservableObject
{
    #region Observables

    [ObservableProperty] private string _email = "oliver.tazueco.baraza@iestubalcain.net";
    [ObservableProperty] private string _password = "Oliver";

    #endregion
    
    #region Commands
    
    #region Login

    [RelayCommand]
    private async Task Login()
    {
        if (await fba.LoginAsync(Email, Password))
        {
            var newShell = new AppShellPost();
            Application.Current!.Windows[0].Page = newShell;
        }
        else
        {
            var toast = Toast.Make("Error al iniciar", ToastDuration.Long);
            await toast.Show();
        }
    }
    
    #endregion
    
    #region GoToRegisterPageCommand

    [RelayCommand]
    private async Task GoToRegisterPage()
    {
        await Shell.Current.GoToAsync(nameof(RegisterPage),true);
    }

    #endregion
    
    #region ForgetPassword

    [RelayCommand]
    private async Task ForgetPassword()
    {
        fba.ChangePasswordAsync(Email);
        await Shell.Current.DisplayAlertAsync("Enviado", $"Se ha enviado un correo a {Email}", "OK");
    }
    
    #endregion
    #endregion
}
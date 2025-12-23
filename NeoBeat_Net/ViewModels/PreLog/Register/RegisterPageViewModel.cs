using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using NeoBeat_Net.Services.FireBase_Authentication;

namespace NeoBeat_Net.ViewModels.PreLog.Register;
using Microsoft.Maui.Controls;
public partial class RegisterPageViewModel(FireBaseAuth fba) : ObservableObject
{
    #region Observables

    [ObservableProperty] private string _email = string.Empty;
    [ObservableProperty] private string _password = string.Empty;
    [ObservableProperty] private string _confirmpassword = string.Empty;

    #endregion
    
    
    #region Commands
    
    #region Register

    [RelayCommand]
    private async Task Register()
    {
        
        if (Password.Equals(Confirmpassword) && CheckEmpy())
        {
            await fba.RegisterAsync(Email, Password);
        }
        else
        {
            await Shell.Current.DisplayAlertAsync("Error", "Contraseñas no coiniciden o Campos Vacios", "Cerrar");
            Email = string.Empty;
            Password = string.Empty;
            Confirmpassword = string.Empty;
        }
    }
    #endregion
    
    
    #region CheckEmptys

    private bool CheckEmpy()
    {
        return !(string.IsNullOrEmpty(Email) || string.IsNullOrEmpty(Password) || string.IsNullOrEmpty(Confirmpassword));
    }
    
    #endregion
    #endregion
}
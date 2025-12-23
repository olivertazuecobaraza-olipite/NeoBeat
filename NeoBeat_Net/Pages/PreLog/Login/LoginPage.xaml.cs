using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NeoBeat_Net.ViewModels.PreLog.Login;

namespace NeoBeat_Net.Pages.PreLog.Login;

public partial class LoginPage : ContentPage
{
    public LoginPage(LoginPageViewModel viewModel)
    {
        InitializeComponent(); 
        BindingContext = viewModel;
    }
}
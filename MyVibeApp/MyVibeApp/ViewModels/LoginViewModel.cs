using MyVibeApp.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace MyVibeApp.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        public Command LoginCommand { get; }
        public Command SignUpCommand { get; }
        public Command ForgotPassCommand { get; }




        public LoginViewModel()
        {
            LoginCommand = new Command(OnLoginClicked);
            SignUpCommand = new Command(OnSignUpClicked);
            ForgotPassCommand = new Command(ForgotPassClicked);
        }

        private async void OnLoginClicked(object obj)
        {
            await Shell.Current.GoToAsync($"//HomePage");
        }

        private async void OnSignUpClicked(object obj)
        {
            await Shell.Current.GoToAsync($"//{nameof(LoginPage)}/{nameof(RegisterPage)}");
        }

        private async void ForgotPassClicked(object obj)
        {
            await Shell.Current.GoToAsync($"//{nameof(LoginPage)}/{nameof(ResetPassPage)}");
        }
    }
}

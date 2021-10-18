using MyVibeApp.Views;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace MyVibeApp.ViewModels
{
    class RegisterViewModel : BaseViewModel
    {
        public Command SignUpAccCommand { get; }

        public RegisterViewModel()
        {
            SignUpAccCommand = new Command(SignUpAccClicked);
        }

        private async void SignUpAccClicked(object obj)
        {
            await Shell.Current.GoToAsync($"//{nameof(LoginPage)}");
        }

    }
}

using MyVibeApp.Views;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace MyVibeApp.ViewModels
{
    class HomeViewModel : BaseViewModel
    {
        public Command LogOutCommand { get; }

        public HomeViewModel()
        {
            LogOutCommand = new Command(LogOutClicked);
        }

        private async void LogOutClicked(object obj)
        {
            await Shell.Current.GoToAsync($"//{nameof(LoginPage)}");
        }

    }
}

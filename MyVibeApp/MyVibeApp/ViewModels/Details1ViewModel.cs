using MyVibeApp.Views;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace MyVibeApp.ViewModels
{
    class Details1ViewModel : BaseViewModel
    {
        public Command LogOutCommand { get; }

        public Details1ViewModel()
        {
            Title = "Details";
            LogOutCommand = new Command(LogOutClicked);
        }

        private async void LogOutClicked(object obj)
        {
            Shell.Current.CurrentPage.Navigation.RemovePage(Shell.Current.CurrentPage);
            
            await Shell.Current.GoToAsync($"//{nameof(LoginPage)}");
        }

    }
}

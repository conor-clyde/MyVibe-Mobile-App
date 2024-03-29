﻿using MyVibeApp.Views;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace MyVibeApp.ViewModels
{
    class HomeViewModel : BaseViewModel
    {
        public Command LogOutCommand { get; }
        public Command CreateCommand { get; }

        public HomeViewModel()
        {
            Title = "Home";
            LogOutCommand = new Command(LogOutClicked);
            CreateCommand = new Command(CreateClicked);
        }

        private async void LogOutClicked(object obj)
        {
            
            await Shell.Current.GoToAsync($"//{nameof(LoginPage)}");
        }

        private async void CreateClicked(object obj)
        {
            await Shell.Current.GoToAsync($"//{nameof(HomePage)}/{nameof(Details1Page)}");
        }

    }
}

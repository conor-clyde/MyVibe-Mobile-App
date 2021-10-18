using MyVibeApp.ViewModels;
using MyVibeApp.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace MyVibeApp
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();

            //Routing.RegisterRoute(nameof(LoginPage), typeof(LoginPage));
            Routing.RegisterRoute(nameof(RegisterPage), typeof(RegisterPage));
            Routing.RegisterRoute(nameof(ResetPassPage), typeof(ResetPassPage));
            //Routing.RegisterRoute(nameof(HomePage), typeof(HomePage));

        }
    }
}

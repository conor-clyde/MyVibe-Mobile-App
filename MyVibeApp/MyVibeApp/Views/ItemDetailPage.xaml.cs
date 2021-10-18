using MyVibeApp.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace MyVibeApp.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}
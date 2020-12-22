using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace WorkoutLogger.ViewModels
{
    public class HomeViewModel : BaseViewModel
    {
        public HomeViewModel()
        {
            Title = "Home";
            //TODO: Change command to ta take you to new workout page
            OpenWebCommand = new Command(async () => await Browser.OpenAsync("https://aka.ms/xamain-quickstart"));
        }

        public ICommand OpenWebCommand { get; }
    }
}
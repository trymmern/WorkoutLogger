using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using WorkoutLogger.Services;
using WorkoutLogger.Views;

namespace WorkoutLogger
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}

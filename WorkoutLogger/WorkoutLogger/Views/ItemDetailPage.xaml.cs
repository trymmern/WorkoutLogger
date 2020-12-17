using System.ComponentModel;
using Xamarin.Forms;
using WorkoutLogger.ViewModels;

namespace WorkoutLogger.Views
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
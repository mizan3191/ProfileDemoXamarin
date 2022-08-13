using MyscoundApp.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace MyscoundApp.Views
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
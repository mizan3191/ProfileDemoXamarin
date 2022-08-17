using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CameraApps
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

           //MainPage = new ProfileUI();
           MainPage = new Profile();
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

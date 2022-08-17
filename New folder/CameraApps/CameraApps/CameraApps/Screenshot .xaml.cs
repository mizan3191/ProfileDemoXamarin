using Plugin.Toasts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CameraApps
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Screenshot : ContentPage
    {
        public Screenshot()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            var notificator = DependencyService.Get<IToastNotificator>();

            var options = new NotificationOptions()
            {
                Title = "Screenshot ",
                Description = "Captured Successfully",
                IsClickable = true,
            };

            var result = await notificator.Notify(options);

            await CaptureScreenshot();
        }
        async Task CaptureScreenshot()
        {
            var screenshot = await Xamarin.Essentials.Screenshot.CaptureAsync();
            var stream = await screenshot.OpenReadAsync();

            ScreenshotButton.Source = ImageSource.FromStream(() => stream);
        }
    }
}
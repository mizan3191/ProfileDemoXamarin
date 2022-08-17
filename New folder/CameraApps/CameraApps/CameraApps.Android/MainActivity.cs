using Android.App;
using Android.Content.PM;
using Android.OS;
using Plugin.Media;
using Plugin.Toasts;
using Xamarin.Forms;

namespace CameraApps.Droid
{
    [Activity(Label = "CameraApps", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, 
        ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize )]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override async void OnCreate(Bundle bundle)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(bundle);
            ToastNotification.Init(this);
            Xamarin.Essentials.Platform.Init(this, bundle);


            await CrossMedia.Current.Initialize();

            global::Xamarin.Forms.Forms.Init(this, bundle);
            DependencyService.Register<ToastNotification>();
            LoadApplication(new App());
        }
    }
}
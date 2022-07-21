using Android.App;
using Android.Content.PM;
using Android.OS;
using Android.Runtime;
using FakeStore.Droid.Services;
using FakeStore.Services;
using FreshMvvm;

namespace FakeStore.Droid
{
    [Activity(Label = "FakeStore", Icon = "@mipmap/icon", Theme = "@style/MainTheme"
                                , ConfigurationChanges = ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            FreshIOC.Container.Register<IPoweredBy, Powered>(); // Singleton / constructor injection to view models

            base.OnCreate(savedInstanceState);

            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);
            LoadApplication(new App());
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}
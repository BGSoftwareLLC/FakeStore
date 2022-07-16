using Android.App;
using System;

namespace FakeStore.Droid
{
    [Activity(Label = "FakeStore", Icon = "@mipmap/icon", Theme = "@style/Theme.Splash", MainLauncher = true)]
    public class SplashActivity : SplashActivityBase.Android.SplashActivityBase
    {
        protected override int splashView => Resource.Layout.SplashLayout;
        protected override Type mainActivity => typeof(MainActivity);
    }
}
using FakeStore.Services;
using FakeStore.Views;
using FakeStore.ViewsModels;
using FreshMvvm;
using SwiftMD.Mobile.App.Services;
using System;
using Xamarin.Forms;

namespace FakeStore
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            try
            {
                FreshIOC.Container.Register<IFakeStoreApi, FakeStoreApi>(); // Singleton / constructor injection to view models

                var loginView = new LoginView();
                var page = FreshPageModelResolver.BindingPageModel(null, loginView, new LoginViewModel());

                FreshPageModelResolver.PageModelMapper = new AppPageModelMapper();
                var navContainer = new FreshNavigationContainer(page, "LoginNavigationContainer");
                MainPage = navContainer;
            }
            catch (Exception e)
            {
                Xamarin.Forms.Application.Current.MainPage.DisplayAlert("Error"
                                                    , e.Message, "Ok");
            }
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

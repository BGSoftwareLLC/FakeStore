using FakeStore.Services;
using FakeStore.ViewModels;
using FakeStore.Views;
using FakeStore.ViewsModels;
using FreshMvvm;
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
                var poweredby = FreshIOC.Container.Resolve<IPoweredBy>();
                var loginPage = FreshPageModelResolver.BindingPageModel(null, loginView, new LoginViewModel(poweredby));

                var fakeStoreItemListView = new FakeStoreItemListView();
                var fakeStoreApi = FreshIOC.Container.Resolve<IFakeStoreApi>();
                var fakeStoreItemListViewPage = FreshPageModelResolver.BindingPageModel(null, fakeStoreItemListView, new FakeStoreItemListViewModel(fakeStoreApi));
                var fakeStoreContainer = new FreshNavigationContainer(fakeStoreItemListViewPage, "FakeStoreContainer")
                {
                    BarBackgroundColor = Color.DarkGray,
                    BarTextColor = Color.Black
                };

                FreshPageModelResolver.PageModelMapper = new AppPageModelMapper();
                var loginContainer = new FreshNavigationContainer(loginPage, "LoginNavigationContainer");
                MainPage = loginContainer;
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

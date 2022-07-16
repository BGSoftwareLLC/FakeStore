using FakeStore.Services;
using System.Windows.Input;
using Xamarin.Forms;
using System;

namespace FakeStore.ViewModels
{
    public class FakeStoreItemListViewModel : BaseViewModel
    {
        public ICommand LogoutCommand
        {
            get
            {
                return new Command(() =>
                {
                    throw new NotImplementedException();
                });
            }
        }

        public FakeStoreItemListViewModel(IFakeStoreApi fakeStoreApi)
        {
            FakeStoreApi = fakeStoreApi;
        }
    }
}
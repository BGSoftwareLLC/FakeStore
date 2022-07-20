using FakeStore.Models;
using FakeStore.Services;
using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Windows.Input;
using Xamarin.Forms;

namespace FakeStore.ViewModels
{
    public class FakeStoreItemListViewModel : BaseViewModel
    {
        public ObservableCollection<FakeStoreItem> FakeStoreItemList { get; private set; }

        public ICommand FakeStoreItemSelectedCommand
        {
            get
            {
                return new Command<FakeStoreItem>(async (fakestoreitem) =>
                {
                    await CoreMethods.PushPageModel<FakeStoreItemViewModel>(fakestoreitem);
                });
            }
        }


        public override async void Init(object initData)
        {
            base.Init(initData);

            try
            {
                var response = await FakeStoreApi.GetFakeStoreItems();
                FakeStoreItemList = new ObservableCollection<FakeStoreItem>(response);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                await CoreMethods.DisplayAlert("Error", ex.Message, "Ok");
            }
        }

        public FakeStoreItemListViewModel(IFakeStoreApi fakeStoreApi)
        {
            FakeStoreApi = fakeStoreApi;
        }
    }
}
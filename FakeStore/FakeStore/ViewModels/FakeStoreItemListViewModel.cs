using FakeStore.Models;
using FakeStore.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Windows.Input;
using Xamarin.Forms;

namespace FakeStore.ViewModels
{
    public class FakeStoreItemListViewModel : BaseViewModel
    {
        public string SelectedSortBy { get; set; } = string.Empty;

        public ObservableCollection<string> SortByList { get; set; } = null;

        public string SelectedCategory { get; set; } = string.Empty;

        public ObservableCollection<string> CategoryList { get; set; } = null;

        public ObservableCollection<FakeStoreItem> FakeStoreItemList { get; private set; }
        private IEnumerable<FakeStoreItem> allfakestoreitems { get; set; }

        private void UpdateFakeStoreItemListByCategoryAndSortOrder()
        {
            Debug.WriteLine($"Category:  {SelectedCategory}");
            Debug.WriteLine($"Sort By:  {SelectedSortBy}");

            switch (SelectedSortBy)
            {
                case "Price":
                    FakeStoreItemList = new ObservableCollection<FakeStoreItem>(SelectedCategory == "All" || SelectedCategory == null ? allfakestoreitems.OrderBy(o => o.price)
                                                                                                        : allfakestoreitems.Where(x => x.category == SelectedCategory).OrderBy(o => o.price));
                    break;
                case "Rating":
                    FakeStoreItemList = new ObservableCollection<FakeStoreItem>(SelectedCategory == "All" || SelectedCategory == null ? allfakestoreitems.OrderBy(o => o.rating.rate)
                                                                                                        : allfakestoreitems.Where(x => x.category == SelectedCategory).OrderBy(o => o.rating.rate));
                    break;
                case "Count":
                    FakeStoreItemList = new ObservableCollection<FakeStoreItem>(SelectedCategory == "All" || SelectedCategory == null ? allfakestoreitems.OrderBy(o => o.rating.count)
                                                                                                        : allfakestoreitems.Where(x => x.category == SelectedCategory).OrderBy(o => o.rating.count));
                    break;
                case "None":
                default:
                    FakeStoreItemList = new ObservableCollection<FakeStoreItem>(SelectedCategory == "All" || SelectedCategory == null ? allfakestoreitems
                                                                                                        : allfakestoreitems.Where(x => x.category == SelectedCategory));
                    break;
            }
        }

        public virtual void OnSelectedCategoryChanged()
        {

            UpdateFakeStoreItemListByCategoryAndSortOrder();
        }

        public virtual void OnSelectedSortByChanged()
        {
            UpdateFakeStoreItemListByCategoryAndSortOrder();
        }

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

        public static readonly IEnumerable<string> sortbylist = new ReadOnlyCollection<string>(new List<string>
        {
            FakeStore.Resources.Resources.idNone,
            FakeStore.Resources.Resources.idPrice,
            FakeStore.Resources.Resources.idRating,
            FakeStore.Resources.Resources.idCount
        });

        public override async void Init(object initData)
        {
            base.Init(initData);

            try
            {
                allfakestoreitems = await FakeStoreApi.GetFakeStoreItems();
                FakeStoreItemList = new ObservableCollection<FakeStoreItem>(allfakestoreitems);
                var fakestorecategories = await FakeStoreApi.GetFakeStoreCategories();
                CategoryList = new ObservableCollection<string>(fakestorecategories);
                CategoryList.Insert(0, FakeStore.Resources.Resources.idAll);  // insert the "All" Category at the beginning
                SortByList = new ObservableCollection<string>(sortbylist);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                await CoreMethods.DisplayAlert(FakeStore.Resources.Resources.idError, ex.Message, FakeStore.Resources.Resources.idOk);
            }
        }

        public FakeStoreItemListViewModel(IFakeStoreApi fakeStoreApi)
        {
            FakeStoreApi = fakeStoreApi;
        }
    }
}
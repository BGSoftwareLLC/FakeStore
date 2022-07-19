using Xamarin.Forms;


namespace FakeStore.Views
{
    public partial class FakeStoreItemListView : ContentPage
    {
        public FakeStoreItemListView()
        {
            InitializeComponent();
        }
        protected override bool OnBackButtonPressed()
        {
            // eat Back button to not allow going back beyond root.  
            return true;
        }
    }
}
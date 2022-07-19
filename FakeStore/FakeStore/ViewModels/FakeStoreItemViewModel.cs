
using System.Windows.Input;
using Xamarin.Forms;
using System;namespace FakeStore.ViewModels
{
    public class FakeStoreItemViewModel : BaseViewModel
    {
        public ICommand LogoutCommand
        {
            get
            {
                return new Command(() =>
                {
                    CoreMethods.SwitchOutRootNavigation("FakeStoreContainer");
                });
            }
        }
    }
}
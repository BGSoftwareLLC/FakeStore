using FakeStore.Services;
using FakeStore.ViewModels;
using System.Diagnostics;
using System.Windows.Input;
using Xamarin.Forms;

namespace FakeStore.ViewsModels
{
    public class LoginViewModel : BaseViewModel
    {
        public bool IsEmailValid { get; set; } = false;
        public bool IsRequiredLength { get; set; } = false;

        public string PoweredBy { get; set; }

        public ICommand LoginCommand
        {
            get
            {
                return new Command(() =>
                {
                    Debug.WriteLine(IsEmailValid);
                    Debug.WriteLine(IsRequiredLength);

                    if (!IsEmailValid)
                        CoreMethods.DisplayAlert("Error", "Please enter a valid email address to login.", "Ok");
                    else if (!IsRequiredLength)
                        CoreMethods.DisplayAlert("Error", "Please enter password of at least 5 characters to login.", "Ok");
                    else
                        CoreMethods.SwitchOutRootNavigation("FakeStoreContainer");


                });
            }
        }

        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;


        public LoginViewModel(IPoweredBy poweredby) : base()
        {
            PoweredBy = poweredby.PoweredBy;
        }

        public override void Init(object initData)
        {
            base.Init(initData);
        }
    }
}

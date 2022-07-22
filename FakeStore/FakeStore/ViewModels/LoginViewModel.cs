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
                        CoreMethods.DisplayAlert(FakeStore.Resources.Resources.idError, FakeStore.Resources.Resources.idInvalidEmail, FakeStore.Resources.Resources.idOk);
                    else if (!IsRequiredLength)
                        CoreMethods.DisplayAlert(FakeStore.Resources.Resources.idError, FakeStore.Resources.Resources.idInvalidPassord, FakeStore.Resources.Resources.idOk);
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

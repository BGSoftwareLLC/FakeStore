using SwiftMD.Mobile.App.ViewModels;

namespace FakeStore.ViewsModels
{
    public class LoginViewModel : BaseViewModel
    {
        public string Username { get; set; } = string.Empty;

        public string Password { get; set; } = string.Empty;


        public LoginViewModel() : base()
        {
        }

        public override void Init(object initData)
        {
            base.Init(initData);


        }
    }
}

using System.ComponentModel;
using Xamarin.Forms;

namespace FakeStore.Triggers
{
    public class ShowHidePasswordTrigger : TriggerAction<ImageButton>, INotifyPropertyChanged
    {
        public string ShowIcon { get; set; }
        public string HideIcon { get; set; }

        public bool HidePassword { get; set; } = true;

        protected override void Invoke(ImageButton sender)
        {
            sender.Source = HidePassword ? HideIcon : ShowIcon;
            HidePassword = !HidePassword;
        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}

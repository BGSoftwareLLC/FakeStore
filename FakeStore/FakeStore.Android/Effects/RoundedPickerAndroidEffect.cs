using FakeStore.Droid.Helpers;
using FakeStore.Effects;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ResolutionGroupName("FakeStore")]
[assembly: ExportEffect(typeof(FakeStore.Android.Effects.RoundedPickerAndroidEffect), nameof(RoundedPickerEffect))]
namespace FakeStore.Android.Effects
{
    public class RoundedPickerAndroidEffect : PlatformEffect
    {
        protected override void OnAttached()
        {
            if (Control != null)
            {
                DrawingHelpers.DrawRoundedBorder(this.Control);
            }
        }

        protected override void OnDetached()
        {
        }
    }
}
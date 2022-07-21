using FakeStore.Effects;
using FakeStore.iOS.Helpers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ResolutionGroupName("FakeStore")]
[assembly: ExportEffect(typeof(FakeStore.iOS.Effects.RoundedPickerIosEffect), nameof(RoundedPickerEffect))]
namespace FakeStore.iOS.Effects
{
    public class RoundedPickerIosEffect : PlatformEffect
    {
        protected override void OnAttached()
        {
            if (this.Control != null)
            {
                DrawingHelpers.DrawRoundedBorder(Control);
            }
        }

        protected override void OnDetached()
        {
        }
    }
}

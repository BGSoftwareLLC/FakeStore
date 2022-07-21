using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

namespace FakeStore.iOS.Helpers
{
    public static class DrawingHelpers
    {
        public static void DrawRoundedBorder(UIKit.UIView control)
        {
            if (control == null) return;
            control.Layer.BorderColor = Color.FromHex("#000000").ToCGColor();
            control.Layer.BorderWidth = 1;
            control.Layer.CornerRadius = 4;
        }
    }
}
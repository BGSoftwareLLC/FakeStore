using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

namespace FakeStore.iOS.Renderers
{
    public static class RendererDrawingHelpers
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
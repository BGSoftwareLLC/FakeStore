using Android.App;
using Android.Content;
using Android.Views;
using AndroidX.Core.Content;

namespace FakeStore.Droid.Helpers
{
    public static class DrawingHelpers
    {
        public static void DrawRoundedBorder(View control)
        {
            Context context = Application.Context;
            if (control == null) return;
            control.Background = ContextCompat.GetDrawable(context, Resource.Drawable.RoundedEntryLayout);
        }
    }
}
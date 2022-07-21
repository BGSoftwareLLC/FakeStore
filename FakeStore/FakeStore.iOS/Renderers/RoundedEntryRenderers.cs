using FakeStore.Controls;
using FakeStore.iOS.Helpers;
using FakeStore.iOS.RoundedEntryRenderer;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(RoundedEntry), typeof(RoundedEntryRenderer))]

namespace FakeStore.iOS.RoundedEntryRenderer
{
    public class RoundedEntryRenderer : EntryRenderer
    {
        public RoundedEntry RoundedEntry => Element as RoundedEntry;

        protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.Entry> e)
        {
            base.OnElementChanged(e);
            DrawingHelpers.DrawRoundedBorder(Control);
        }

        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);
        }
    }
}
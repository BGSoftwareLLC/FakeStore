using System.ComponentModel;
using FakeStore.Controls;
using FakeStore.iOS.RoundedEntryRenderer;
using UIKit;
using Xamarin.Forms.Platform.iOS;
using Xamarin.Forms;
using FakeStore.iOS.Renderers;

[assembly: ExportRenderer (typeof(RoundedEntry), typeof(RoundedEntryRenderer))]

namespace FakeStore.iOS.RoundedEntryRenderer
{
    public class RoundedEntryRenderer : EntryRenderer
    {
        public RoundedEntry RoundedEntry => Element as RoundedEntry;

        protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.Entry> e)
        {
            base.OnElementChanged(e);
            RendererDrawingHelpers.DrawRoundedBorder(Control);
        }

        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);
        }
    }
}
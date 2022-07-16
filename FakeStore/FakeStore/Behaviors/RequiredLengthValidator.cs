using Xamarin.Forms;

namespace FakeStore.Behaviors
{
    public class RequiredLengthValidator : Behavior<Entry>
    {
        public static readonly BindableProperty RequiredLengthProperty
                        = BindableProperty.Create("RequiredLength"
                        , typeof(int), typeof(RequiredLengthValidator), 0);
        public static readonly BindableProperty IsRequiredLengthProperty
                        = BindableProperty.Create("IsRequiredLength"
                        , typeof(bool), typeof(RequiredLengthValidator), false);

        public int RequiredLength
        {
            get { return (int)GetValue(RequiredLengthProperty); }
            set { SetValue(RequiredLengthProperty, value); }
        }
        public bool IsRequiredLength
        {
            get { return (bool)GetValue(IsRequiredLengthProperty); }
            set { SetValue(IsRequiredLengthProperty, value); }
        }


        protected override void OnAttachedTo(Entry bindable)
        {
            bindable.TextChanged += bindable_TextChanged;
        }

        private void bindable_TextChanged(object sender, TextChangedEventArgs e)
        {
            IsRequiredLength = (e.NewTextValue.Length >= RequiredLength);
            ((Entry)sender).TextColor = !IsRequiredLength ? Color.Red : Color.FromHex("A8A6A7");
        }

        protected override void OnDetachingFrom(Entry bindable)
        {
            bindable.TextChanged -= bindable_TextChanged;
        }
    }
}

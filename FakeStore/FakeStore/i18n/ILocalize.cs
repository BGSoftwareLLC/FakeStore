using System.Globalization;

namespace FakeStore.i18n
{
    public interface ILocalize
    {
        CultureInfo GetCurrentCultureInfo();

        void SetLocale();
    }
}

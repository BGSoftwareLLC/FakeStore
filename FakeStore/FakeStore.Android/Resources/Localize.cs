using FakeStore.Droid.Resources;
using FakeStore.i18n;
using Java.Util;
using System.Globalization;
using System.Linq;
using System.Threading;
using Xamarin.Forms;

// todo cnymann:  use DI container FreshMvvm instead of Xamarin Dependency Service?  
[assembly: Dependency(typeof(Localize))]
namespace FakeStore.Droid.Resources
{
    public class Localize : ILocalize
    {
        #region Public Methods

        public CultureInfo GetCurrentCultureInfo()
        {
            var androidLocale = Locale.Default;

            var language = androidLocale.ToString().Replace("_", "-");

            var cultures = CultureInfo.GetCultures(CultureTypes.AllCultures);
            if (!cultures.Any(c => c.Name == language))
            {
                language = "en";
            }

            return new CultureInfo(language);
        }

        public void SetLocale()
        {
            var culture = GetCurrentCultureInfo();

            Thread.CurrentThread.CurrentCulture = culture;
            Thread.CurrentThread.CurrentUICulture = culture;
        }

        #endregion
    }
}
using FakeStore.Services;

namespace FakeStore.Droid.Services
{
    public class Powered : IPoweredBy
    {
        public string PoweredBy
        {
            get { return "Powered By Android"; }
        }
    }
}
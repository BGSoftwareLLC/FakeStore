using FakeStore.Services;

namespace FakeStore.iOS.Services
{
    public class Powered : IPoweredBy
    {
        public string PoweredBy
        {
            get { return "Powered By IOS"; }
        }
    }
}
using System;

namespace FakeStore.Exceptions
{
    internal class FakeStoreApiException : Exception
    {
        public FakeStoreApiException()
        {
        }

        public FakeStoreApiException(string message) : base(message)
        {
        }

        public FakeStoreApiException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}

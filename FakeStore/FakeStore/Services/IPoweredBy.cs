namespace FakeStore.Services
{
    /// <summary>
    /// returns the platform powering the app
    /// the implementation is platform dependent residing in the platform implementation
    /// </summary>
    public interface IPoweredBy
    {
        string PoweredBy { get; }
    }
}

using FakeStore.Models;
using Refit;
using System.Threading.Tasks;

namespace FakeStore.Services
{
    [Headers("Content-Type: application/json", "Accept: */*", "Connection: keep-alive", "Accept: text/plain")]
    public interface IFakeStoreApi
    {
        [Get("/products")]
        Task<FakeStoreItemsResponse> GetFakeStoreItems();
    }
}

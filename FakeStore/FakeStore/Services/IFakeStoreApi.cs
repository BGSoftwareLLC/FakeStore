using FakeStore.Models;
using Refit;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FakeStore.Services
{
    public interface IFakeStoreApi
    {
        [Get("/products")]
        Task<IEnumerable<FakeStoreItem>> GetFakeStoreItems();

        [Get("/products/categories")]
        Task<IEnumerable<string>> GetFakeStoreCategories();
    }
}

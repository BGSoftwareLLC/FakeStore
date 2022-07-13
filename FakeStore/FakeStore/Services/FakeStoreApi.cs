using FakeStore.Models;
using Refit;
using System.Threading.Tasks;

namespace FakeStore.Services
{
    class FakeStoreApi : IFakeStoreApi
    {
        private IFakeStoreApi fakestoreapi { get; set; }
        private string url => "https://fakestoreapi.com";

        public FakeStoreApi()
        {
            fakestoreapi = RestService.For<IFakeStoreApi>(url);
        }

        public async Task<FakeStoreItemsResponse> GetFakeStoreItems()
        {
            var response = await fakestoreapi.GetFakeStoreItems();
            return response;
        }
    }
}

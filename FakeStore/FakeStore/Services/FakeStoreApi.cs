using FakeStore.Models;
using Refit;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FakeStore.Services
{
    public class FakeStoreApi : IFakeStoreApi
    {
        private IFakeStoreApi fakestoreapi { get; set; }
        private string url => "https://fakestoreapi.com";

        public FakeStoreApi()
        {
            fakestoreapi = RestService.For<IFakeStoreApi>(url);
        }

        public async Task<IEnumerable<FakeStoreItem>> GetFakeStoreItems()
        {
            var response = await fakestoreapi.GetFakeStoreItems();
            return response;
        }
    }
}

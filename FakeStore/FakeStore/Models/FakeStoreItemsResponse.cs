using System.Collections.Generic;

namespace FakeStore.Models
{
    public class FakeStoreItemsResponse
    {
        public IEnumerable<FakeStoreItem> FakeStoreItems { get; set; }
    }
}

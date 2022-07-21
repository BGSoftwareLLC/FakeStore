using FakeStore.Models;

namespace FakeStore.ViewModels
{
    public class FakeStoreItemViewModel : BaseViewModel
    {
        public int Count { get; set; } = 0;

        public float Rate { get; set; } = 0;

        public float Price { get; set; } = 0;

        public string Category { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public string Title { get; set; } = string.Empty;

        public string Image { get; set; } = string.Empty;

        public override void Init(object initData)
        {
            base.Init(initData);
            var fakestoreitem = initData as FakeStoreItem;
            Image = fakestoreitem.image;
            Title = fakestoreitem.title;
            Description = fakestoreitem.description;
            Category = fakestoreitem.category;

            Price = fakestoreitem.price;
            Rate = fakestoreitem.rating.rate;
            Count = fakestoreitem.rating.count;
        }
    }
}
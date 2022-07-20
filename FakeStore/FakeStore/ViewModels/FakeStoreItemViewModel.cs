using FakeStore.Models;

namespace FakeStore.ViewModels
{
    public class FakeStoreItemViewModel : BaseViewModel
    {
        public string Count { get; set; } = string.Empty;

        public string Rate { get; set; } = string.Empty;

        public string Price { get; set; } = string.Empty;

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

            Price = fakestoreitem.price.ToString("0.00");
            Rate = fakestoreitem.rating.rate.ToString("0.0");
            Count = fakestoreitem.rating.count.ToString("0");
        }
    }
}
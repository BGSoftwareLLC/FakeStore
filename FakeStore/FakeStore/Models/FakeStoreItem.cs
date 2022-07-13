﻿namespace FakeStore.Models
{
    public class FakeStoreItem
    {
        public int id { get; set; }
        public string title { get; set; }
        public float price { get; set; }
        public string description { get; set; }
        public string category { get; set; }
        public string image { get; set; }
        class Rating
        {
            public float rate { get; set; }
            public int count { get; set; }
        }
    }
}







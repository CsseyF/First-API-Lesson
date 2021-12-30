using System;

namespace Catalog.Entities{
    public class Item{
        public Guid Id{get; init;}
        public string Name {get; init;}
        public float Price {get; init;}

        public DateTimeOffset CreatedDate {get; init;}
    }
}
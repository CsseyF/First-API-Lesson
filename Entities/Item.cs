namespace Catalog.Entities{
    public record Item{
        public Guid Id{get; init;}
        public string Name {get; init;}
        public float Price {get; init;}

        public DateTimeOffset CreatedDate {get; init;}
    }
}
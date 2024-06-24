namespace NLayer.Core.DTOs
{
    public record ProductCreateDto
    {
        public string Name { get; init; }

        public int Stock { get; init; }
        public decimal Price { get; init; }

        public int CategoryId { get; init; }
    }
}

namespace NLayer.Core.DTOs
{
    public record ProductDto : BaseDto
    {


        public string Name { get; init; }

        public int Stock { get; init; }
        public decimal Price { get; init; }

        public int CategoryId { get; init; }
    }
}

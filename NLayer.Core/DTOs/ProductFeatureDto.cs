namespace NLayer.Core.DTOs
{
    public record ProductFeatureDto
    {

        public int Id { get; init; }
        public string Color { get; init; }
        public int Height { get; init; }
        public int Width { get; init; }

        public int ProductId { get; init; }
    }
}

namespace NLayer.Core.DTOs
{
    public record ProductWithCategoryDto : ProductDto
    {
        public CategoryDto Category { get; init; }
    }
}

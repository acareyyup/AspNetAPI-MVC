namespace NLayer.Core.DTOs
{
    public record CategoryWithProductsDto : CategoryDto
    {
        public List<ProductDto> Products { get; init; }
    }
}

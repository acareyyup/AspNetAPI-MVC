﻿using NLayer.Core.DTOs;

namespace NLayer.Core.Services
{
    public interface IProductServiceWithDto : IServiceWithDto<Product, ProductDto>
    {
        Task<CustomResponseDto<List<ProductWithCategoryDto>>> GetProductsWitCategory();
        Task<CustomResponseDto<NoContentDto>> UpdateAsync(ProductUpdateDto dto);
        Task<CustomResponseDto<ProductDto>> AddAsync(ProductCreateDto dto);
    }
}
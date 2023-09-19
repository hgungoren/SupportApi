using Abp.Application.Services;
using SK.Support.Products.Dto;
using System;

namespace SK.Support.Products
{
    public interface IProductAppService : IAsyncCrudAppService<ProductDto, Guid, PagedProductResultRequestDto, CreateProductDto, ProductDto>
    { }
}

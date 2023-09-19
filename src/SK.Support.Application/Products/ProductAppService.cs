using Abp.Application.Services;
using Abp.Collections.Extensions;
using Abp.Domain.Repositories;
using SK.Support.Products.Dto;
using System;
using System.Linq;
using Abp.Extensions;
using Abp.Linq.Extensions;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;

namespace SK.Support.Products
{
    public class ProductAppService : AsyncCrudAppService<Product, ProductDto, Guid, PagedProductResultRequestDto, CreateProductDto, ProductDto>, IProductAppService
    {
        public ProductAppService(IRepository<Product, Guid> repository) : base(repository)
        { }

        protected override IQueryable<Product> CreateFilteredQuery(PagedProductResultRequestDto input)
        {
            var products = Repository.GetAllIncluding()
                .WhereIf(!input.Keyword.IsNullOrWhiteSpace(), x => x.ProductName.ToLower().Contains(input.Keyword.ToLower()));


            return products;
        }
        public override Task<PagedResultDto<ProductDto>> GetAllAsync(PagedProductResultRequestDto input)
        {
            return base.GetAllAsync(input);
        }
    }
}

using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using SK.Support.ProductModels.Dto;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SK.Support.ProductModels
{
    public class ProductModelAppService : AsyncCrudAppService<ProductModel, ProductModelDto, Guid, PagedProductModelResultRequestDto, CreateProductModelDto, ProductModelDto>, IProductModelAppService
    {
        public ProductModelAppService(IRepository<ProductModel, Guid> repository) : base(repository)
        {  
        } 

        public async Task<PagedResultDto<ProductModelDto>> GetByProductIdAsync(Guid id)
        {
            var data = await Repository.GetAllListAsync(x => x.ProductId == id);
            return new PagedResultDto<ProductModelDto>
            {
                TotalCount = data.Count,
                Items = ObjectMapper.Map<List<ProductModelDto>>(data),
            };
        }
    }
}

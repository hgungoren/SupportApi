using Abp.Application.Services;
using Abp.Application.Services.Dto;
using SK.Support.ProductModels.Dto;
using System;
using System.Threading.Tasks;

namespace SK.Support.ProductModels
{
    public interface IProductModelAppService : IAsyncCrudAppService<ProductModelDto, Guid, PagedProductModelResultRequestDto, CreateProductModelDto, ProductModelDto> {

        Task<PagedResultDto<ProductModelDto>> GetByProductIdAsync(Guid id);

    }
}

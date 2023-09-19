using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using SK.Support.TechnicalServices.Dto;
using System;
using System.Threading.Tasks;

namespace SK.Support.TechnicalServices
{
    public class TechnicalSupportAppService : AsyncCrudAppService<TechnicalService, TechnicalServiceDto, Guid, PagedTechnicalServiceResultRequestDto, CreateTechnicalServiceDto, TechnicalServiceDto>, ITechnicalServiceAppService
    {
        public TechnicalSupportAppService(IRepository<TechnicalService, Guid> repository) : base(repository)
        {

        }
        public override Task<TechnicalServiceDto> CreateAsync(CreateTechnicalServiceDto input)
        {
            return base.CreateAsync(input);
        }
    }
}

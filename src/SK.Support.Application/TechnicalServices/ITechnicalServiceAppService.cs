using Abp.Application.Services;
using SK.Support.TechnicalServices.Dto;
using System;

namespace SK.Support.TechnicalServices
{
    public interface ITechnicalServiceAppService : IAsyncCrudAppService<TechnicalServiceDto, Guid,PagedTechnicalServiceResultRequestDto, CreateTechnicalServiceDto, TechnicalServiceDto>
    { }
}

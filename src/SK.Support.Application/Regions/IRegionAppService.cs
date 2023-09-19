using Abp.Application.Services;
using SK.Support.Regions.Dto;
using System;

namespace SK.Support.Regions
{
    public interface IRegionAppService : IAsyncCrudAppService<RegionDto, Guid, PagedRegionResultRequestDto, CreateRegionDto, RegionDto>
    { }
}

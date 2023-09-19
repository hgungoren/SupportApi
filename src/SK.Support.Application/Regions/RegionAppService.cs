using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Collections.Extensions;
using Abp.Domain.Repositories;
using Refit;
using SK.Support.Regions.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SK.Support.Regions
{
    public class RegionAppService : AsyncCrudAppService<Region, RegionDto, Guid, PagedRegionResultRequestDto, CreateRegionDto, RegionDto>, IRegionAppService
    {
        private const string SERENDIP_SERVICE_BASE_URL = "http://10.27.1.74:1903/api/v1/";
        private const string SERENDIP_SERVICE_BASE_URL1 = "http://10.27.1.74:1924/api/ksube/";

        public RegionAppService(IRepository<Region, Guid> repository) : base(repository)
        {
        }
        public override async Task<PagedResultDto<RegionDto>> GetAllAsync(PagedRegionResultRequestDto input)
        {
            var service = RestService.For<IRegionAppApi>(SERENDIP_SERVICE_BASE_URL);
            var data = await service.GetAll();
            
            List<RegionDto> regions = new List<RegionDto>();

            foreach (var branch in data)
            {
                RegionDto branchDto = new RegionDto();
                branchDto.Adi = branch.Adi;
                regions.Add(branchDto);
            }  
            return new PagedResultDto<RegionDto>
            {
                Items=regions
            };
        }
        public async Task<PagedResultDto<RegionResponseDto>> GetRegionNameByType(string id)
        {
            var service = RestService.For<IRegionInkaAppApi>(SERENDIP_SERVICE_BASE_URL1);
            var data = await service.GetAreaByType(id);

            List<RegionResponseDto> regions = new List<RegionResponseDto>(); 
            

            foreach (var branch in data)
            {RegionResponseDto branchDto = new RegionResponseDto();
                branchDto.BirimAdi = branch.BirimAdi;
                branchDto.ObjId = branch.ObjId.ToString();
                regions.Add(branchDto);
            }
            return new PagedResultDto<RegionResponseDto>
            {
                Items = regions
            };
        }
    }
}



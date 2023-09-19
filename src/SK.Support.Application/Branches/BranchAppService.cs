using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Collections.Extensions;
using Abp.Domain.Repositories;
using Refit;
using SK.Support.Branches.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SK.Support.Branches
{
    public class BranchAppService : AsyncCrudAppService<Branch, BranchDto, Guid, PagedBranchResultRequestDto, CreateBranchDto, BranchDto>, IBranchAppService
    {
        private const string SERENDIP_SERVICE_BASE_URL = "http://10.27.1.74:1924/api/ksube/";
        
        public BranchAppService(IRepository<Branch, Guid> repository) : base(repository)
        {
        
        }  
        public async Task<PagedResultDto<BranchResponseDto>> GetById(long id)
        {
            var service = RestService.For<IBranchAppApi>(SERENDIP_SERVICE_BASE_URL);
            var data = await service.GetAll(id);

            List<BranchResponseDto> branches = new List<BranchResponseDto>();
            foreach (var branch in data)
            {
                BranchResponseDto branchDto = new BranchResponseDto();
                branchDto.BirimAdi = branch.BirimAdi;
                branchDto.ObjId = branch.ObjId.ToString(); ;
                branches.Add(branchDto);
            }
            return new PagedResultDto<BranchResponseDto>
            {
                Items = branches
            };
        }

    }
}

using Abp.Application.Services;
using SK.Support.Branches.Dto;
using System;

namespace SK.Support.Branches
{
    public interface IBranchAppService : IAsyncCrudAppService<BranchDto, Guid, PagedBranchResultRequestDto, CreateBranchDto, BranchDto>
    {
    }
}

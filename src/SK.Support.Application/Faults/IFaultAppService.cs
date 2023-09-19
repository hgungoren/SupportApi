using Abp.Application.Services;
using SK.Support.Faults.Dto;
using System;

namespace SK.Support.Faults
{
    internal interface IFaultAppService : IAsyncCrudAppService<FaultDto, Guid, PagedFaultResultRequestDto, CreateFaultDto, FaultDto> { }
}

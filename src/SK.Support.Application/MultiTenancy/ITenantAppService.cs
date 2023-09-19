using Abp.Application.Services;
using SK.Support.MultiTenancy.Dto;

namespace SK.Support.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}


using System.Threading.Tasks;
using Abp.Application.Services;
using SK.Support.Authorization.Accounts.Dto;

namespace SK.Support.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}

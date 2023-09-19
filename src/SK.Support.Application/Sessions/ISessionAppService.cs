using System.Threading.Tasks;
using Abp.Application.Services;
using SK.Support.Sessions.Dto;

namespace SK.Support.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}

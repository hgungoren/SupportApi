using System.Threading.Tasks;
using SK.Support.Configuration.Dto;

namespace SK.Support.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}

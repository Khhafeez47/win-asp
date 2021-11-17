using System.Threading.Tasks;
using win-asp-core-iis.Configuration.Dto;

namespace win-asp-core-iis.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}

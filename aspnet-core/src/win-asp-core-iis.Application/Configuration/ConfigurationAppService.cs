using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using win-asp-core-iis.Configuration.Dto;

namespace win-asp-core-iis.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : win-asp-core-iisAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}

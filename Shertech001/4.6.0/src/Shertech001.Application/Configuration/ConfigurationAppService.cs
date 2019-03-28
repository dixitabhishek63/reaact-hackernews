using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using Shertech001.Configuration.Dto;

namespace Shertech001.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : Shertech001AppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}

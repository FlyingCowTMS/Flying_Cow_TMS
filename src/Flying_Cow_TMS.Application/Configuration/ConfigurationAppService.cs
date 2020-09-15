using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using Flying_Cow_TMS.Configuration.Dto;

namespace Flying_Cow_TMS.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : Flying_Cow_TMSAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}

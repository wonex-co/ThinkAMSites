using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using ThinkAM.Sites.Configuration.Dto;

namespace ThinkAM.Sites.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : SitesAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}

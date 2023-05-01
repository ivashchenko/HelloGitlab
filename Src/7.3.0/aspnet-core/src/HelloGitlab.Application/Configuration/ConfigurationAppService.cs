using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using HelloGitlab.Configuration.Dto;

namespace HelloGitlab.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : HelloGitlabAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}

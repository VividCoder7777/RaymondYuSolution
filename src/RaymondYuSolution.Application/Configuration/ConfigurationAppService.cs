using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using RaymondYuSolution.Configuration.Dto;

namespace RaymondYuSolution.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : RaymondYuSolutionAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}

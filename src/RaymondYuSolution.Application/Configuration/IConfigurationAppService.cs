using System.Threading.Tasks;
using RaymondYuSolution.Configuration.Dto;

namespace RaymondYuSolution.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}

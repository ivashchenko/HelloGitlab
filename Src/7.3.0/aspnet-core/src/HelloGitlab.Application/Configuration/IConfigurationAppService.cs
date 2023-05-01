using System.Threading.Tasks;
using HelloGitlab.Configuration.Dto;

namespace HelloGitlab.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}

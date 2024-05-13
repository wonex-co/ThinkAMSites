using System.Threading.Tasks;
using ThinkAM.Sites.Configuration.Dto;

namespace ThinkAM.Sites.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}

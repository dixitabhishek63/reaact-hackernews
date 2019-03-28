using System.Threading.Tasks;
using Shertech001.Configuration.Dto;

namespace Shertech001.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}

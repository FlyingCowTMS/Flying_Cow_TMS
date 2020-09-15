using System.Threading.Tasks;
using Flying_Cow_TMS.Configuration.Dto;

namespace Flying_Cow_TMS.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}

using System.Threading.Tasks;
using Abp.Application.Services;
using Flying_Cow_TMS.Sessions.Dto;

namespace Flying_Cow_TMS.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}

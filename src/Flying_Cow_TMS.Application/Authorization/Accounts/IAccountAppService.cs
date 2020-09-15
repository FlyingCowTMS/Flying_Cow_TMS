using System.Threading.Tasks;
using Abp.Application.Services;
using Flying_Cow_TMS.Authorization.Accounts.Dto;

namespace Flying_Cow_TMS.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}

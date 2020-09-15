using Abp.Application.Services;
using Flying_Cow_TMS.MultiTenancy.Dto;

namespace Flying_Cow_TMS.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}


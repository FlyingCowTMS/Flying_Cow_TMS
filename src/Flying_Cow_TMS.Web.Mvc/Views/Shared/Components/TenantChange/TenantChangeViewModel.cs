using Abp.AutoMapper;
using Flying_Cow_TMS.Sessions.Dto;

namespace Flying_Cow_TMS.Web.Views.Shared.Components.TenantChange
{
    [AutoMapFrom(typeof(GetCurrentLoginInformationsOutput))]
    public class TenantChangeViewModel
    {
        public TenantLoginInfoDto Tenant { get; set; }
    }
}

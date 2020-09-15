using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Flying_Cow_TMS.MultiTenancy;

namespace Flying_Cow_TMS.Sessions.Dto
{
    [AutoMapFrom(typeof(Tenant))]
    public class TenantLoginInfoDto : EntityDto
    {
        public string TenancyName { get; set; }

        public string Name { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;
using Abp.MultiTenancy;

namespace Flying_Cow_TMS.Authorization.Accounts.Dto
{
    public class IsTenantAvailableInput
    {
        [Required]
        [StringLength(AbpTenantBase.MaxTenancyNameLength)]
        public string TenancyName { get; set; }
    }
}

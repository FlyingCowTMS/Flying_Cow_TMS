using Abp.MultiTenancy;
using Flying_Cow_TMS.Authorization.Users;

namespace Flying_Cow_TMS.MultiTenancy
{
    public class Tenant : AbpTenant<User>
    {
        public Tenant()
        {            
        }

        public Tenant(string tenancyName, string name)
            : base(tenancyName, name)
        {
        }
    }
}

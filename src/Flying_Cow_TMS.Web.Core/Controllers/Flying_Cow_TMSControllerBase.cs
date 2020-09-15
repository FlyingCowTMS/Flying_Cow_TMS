using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace Flying_Cow_TMS.Controllers
{
    public abstract class Flying_Cow_TMSControllerBase: AbpController
    {
        protected Flying_Cow_TMSControllerBase()
        {
            LocalizationSourceName = Flying_Cow_TMSConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}

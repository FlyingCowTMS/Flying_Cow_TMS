using Abp.AspNetCore.Mvc.ViewComponents;

namespace Flying_Cow_TMS.Web.Views
{
    public abstract class Flying_Cow_TMSViewComponent : AbpViewComponent
    {
        protected Flying_Cow_TMSViewComponent()
        {
            LocalizationSourceName = Flying_Cow_TMSConsts.LocalizationSourceName;
        }
    }
}

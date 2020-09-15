using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;
using Microsoft.AspNetCore.Mvc.Razor.Internal;

namespace Flying_Cow_TMS.Web.Views
{
    public abstract class Flying_Cow_TMSRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected Flying_Cow_TMSRazorPage()
        {
            LocalizationSourceName = Flying_Cow_TMSConsts.LocalizationSourceName;
        }
    }
}

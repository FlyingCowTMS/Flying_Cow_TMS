using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using Flying_Cow_TMS.Controllers;

namespace Flying_Cow_TMS.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : Flying_Cow_TMSControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}

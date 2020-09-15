using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Flying_Cow_TMS.Configuration;

namespace Flying_Cow_TMS.Web.Startup
{
    [DependsOn(typeof(Flying_Cow_TMSWebCoreModule))]
    public class Flying_Cow_TMSWebMvcModule : AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public Flying_Cow_TMSWebMvcModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void PreInitialize()
        {
            Configuration.Navigation.Providers.Add<Flying_Cow_TMSNavigationProvider>();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(Flying_Cow_TMSWebMvcModule).GetAssembly());
        }
    }
}

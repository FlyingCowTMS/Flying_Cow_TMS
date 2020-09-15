using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Flying_Cow_TMS.EntityFrameworkCore;
using Flying_Cow_TMS.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace Flying_Cow_TMS.Web.Tests
{
    [DependsOn(
        typeof(Flying_Cow_TMSWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class Flying_Cow_TMSWebTestModule : AbpModule
    {
        public Flying_Cow_TMSWebTestModule(Flying_Cow_TMSEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(Flying_Cow_TMSWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(Flying_Cow_TMSWebMvcModule).Assembly);
        }
    }
}
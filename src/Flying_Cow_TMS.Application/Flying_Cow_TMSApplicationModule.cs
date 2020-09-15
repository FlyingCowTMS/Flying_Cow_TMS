using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Flying_Cow_TMS.Authorization;

namespace Flying_Cow_TMS
{
    [DependsOn(
        typeof(Flying_Cow_TMSCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class Flying_Cow_TMSApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<Flying_Cow_TMSAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(Flying_Cow_TMSApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}

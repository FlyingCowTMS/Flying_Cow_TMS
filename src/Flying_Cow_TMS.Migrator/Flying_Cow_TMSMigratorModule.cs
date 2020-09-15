using Microsoft.Extensions.Configuration;
using Castle.MicroKernel.Registration;
using Abp.Events.Bus;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Flying_Cow_TMS.Configuration;
using Flying_Cow_TMS.EntityFrameworkCore;
using Flying_Cow_TMS.Migrator.DependencyInjection;

namespace Flying_Cow_TMS.Migrator
{
    [DependsOn(typeof(Flying_Cow_TMSEntityFrameworkModule))]
    public class Flying_Cow_TMSMigratorModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public Flying_Cow_TMSMigratorModule(Flying_Cow_TMSEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbSeed = true;

            _appConfiguration = AppConfigurations.Get(
                typeof(Flying_Cow_TMSMigratorModule).GetAssembly().GetDirectoryPathOrNull()
            );
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(
                Flying_Cow_TMSConsts.ConnectionStringName
            );

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
            Configuration.ReplaceService(
                typeof(IEventBus), 
                () => IocManager.IocContainer.Register(
                    Component.For<IEventBus>().Instance(NullEventBus.Instance)
                )
            );
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(Flying_Cow_TMSMigratorModule).GetAssembly());
            ServiceCollectionRegistrar.Register(IocManager);
        }
    }
}

using Abp.EntityFrameworkCore.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Abp.Zero.EntityFrameworkCore;
using Flying_Cow_TMS.EntityFrameworkCore.Seed;

namespace Flying_Cow_TMS.EntityFrameworkCore
{
    [DependsOn(
        typeof(Flying_Cow_TMSCoreModule), 
        typeof(AbpZeroCoreEntityFrameworkCoreModule))]
    public class Flying_Cow_TMSEntityFrameworkModule : AbpModule
    {
        /* Used it tests to skip dbcontext registration, in order to use in-memory database of EF Core */
        public bool SkipDbContextRegistration { get; set; }

        public bool SkipDbSeed { get; set; }

        public override void PreInitialize()
        {
            if (!SkipDbContextRegistration)
            {
                Configuration.Modules.AbpEfCore().AddDbContext<Flying_Cow_TMSDbContext>(options =>
                {
                    if (options.ExistingConnection != null)
                    {
                        Flying_Cow_TMSDbContextConfigurer.Configure(options.DbContextOptions, options.ExistingConnection);
                    }
                    else
                    {
                        Flying_Cow_TMSDbContextConfigurer.Configure(options.DbContextOptions, options.ConnectionString);
                    }
                });
            }
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(Flying_Cow_TMSEntityFrameworkModule).GetAssembly());
        }

        public override void PostInitialize()
        {
            if (!SkipDbSeed)
            {
                SeedHelper.SeedHostDb(IocManager);
            }
        }
    }
}

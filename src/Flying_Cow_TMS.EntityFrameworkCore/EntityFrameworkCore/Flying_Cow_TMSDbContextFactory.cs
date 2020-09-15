using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Flying_Cow_TMS.Configuration;
using Flying_Cow_TMS.Web;

namespace Flying_Cow_TMS.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class Flying_Cow_TMSDbContextFactory : IDesignTimeDbContextFactory<Flying_Cow_TMSDbContext>
    {
        public Flying_Cow_TMSDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<Flying_Cow_TMSDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            Flying_Cow_TMSDbContextConfigurer.Configure(builder, configuration.GetConnectionString(Flying_Cow_TMSConsts.ConnectionStringName));

            return new Flying_Cow_TMSDbContext(builder.Options);
        }
    }
}

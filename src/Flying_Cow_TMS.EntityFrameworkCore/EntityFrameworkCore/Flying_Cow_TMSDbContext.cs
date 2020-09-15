using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Flying_Cow_TMS.Authorization.Roles;
using Flying_Cow_TMS.Authorization.Users;
using Flying_Cow_TMS.MultiTenancy;

namespace Flying_Cow_TMS.EntityFrameworkCore
{
    public class Flying_Cow_TMSDbContext : AbpZeroDbContext<Tenant, Role, User, Flying_Cow_TMSDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public Flying_Cow_TMSDbContext(DbContextOptions<Flying_Cow_TMSDbContext> options)
            : base(options)
        {
        }
    }
}

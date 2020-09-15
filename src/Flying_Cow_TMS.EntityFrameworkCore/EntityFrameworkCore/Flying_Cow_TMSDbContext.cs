using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Flying_Cow_TMS.Authorization.Roles;
using Flying_Cow_TMS.Authorization.Users;
using Flying_Cow_TMS.MultiTenancy;
using Flying_Cow_TMS.Entities;

namespace Flying_Cow_TMS.EntityFrameworkCore
{
    public class Flying_Cow_TMSDbContext : AbpZeroDbContext<Tenant, Authorization.Roles.Role, User, Flying_Cow_TMSDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public Flying_Cow_TMSDbContext(DbContextOptions<Flying_Cow_TMSDbContext> options)
            : base(options)
        {
        }
        public DbSet<Abnormal> Abnormal { get; set; }
        public DbSet<Address> Address { get; set; }
        public DbSet<Anomaly> Anomaly { get; set; }
        public DbSet<Carrier_Profit> Carrier_Profit { get; set; }
        public DbSet<Consignee> Consignee { get; set; }
        public DbSet<Dispatch> Dispatch { get; set; }
        public DbSet<Takegoods> Takegoods { get; set; }
        public DbSet<UserInfo> UserInfo { get; set; }
        public DbSet<UserRole> UserRole { get; set; }
        public DbSet<Entities.Role> Role { get; set; }
        public DbSet<RoleJurisdiction> RoleJurisdiction { get; set; }
        public DbSet<Route> Route { get; set; }
        public DbSet<Jurisdiction> Jurisdiction { get; set; }
        public DbSet<Offer> Offer { get; set; }
        public DbSet<Receipt> Receipt { get; set; }
        public DbSet<Driver> Driver { get; set; } // 司机表

        public DbSet<Driver_Quotation> Driver_Quotation { get; set; }// 司机报价表

        public DbSet<Entrust> Entrust { get; set; }// 委托表

        public DbSet<Inquiry> Inquiry { get; set; }// 询价表

    }
}

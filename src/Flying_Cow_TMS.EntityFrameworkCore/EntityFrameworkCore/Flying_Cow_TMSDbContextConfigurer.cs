using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace Flying_Cow_TMS.EntityFrameworkCore
{
    public static class Flying_Cow_TMSDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<Flying_Cow_TMSDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<Flying_Cow_TMSDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}

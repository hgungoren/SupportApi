using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace SK.Support.EntityFrameworkCore
{
    public static class SupportDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<SupportDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<SupportDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}

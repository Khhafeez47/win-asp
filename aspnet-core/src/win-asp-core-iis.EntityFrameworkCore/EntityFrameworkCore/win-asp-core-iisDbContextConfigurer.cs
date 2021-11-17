using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace win-asp-core-iis.EntityFrameworkCore
{
    public static class win-asp-core-iisDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<win-asp-core-iisDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<win-asp-core-iisDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}

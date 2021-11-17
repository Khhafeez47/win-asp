using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using win-asp-core-iis.Authorization.Roles;
using win-asp-core-iis.Authorization.Users;
using win-asp-core-iis.MultiTenancy;

namespace win-asp-core-iis.EntityFrameworkCore
{
    public class win-asp-core-iisDbContext : AbpZeroDbContext<Tenant, Role, User, win-asp-core-iisDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public win-asp-core-iisDbContext(DbContextOptions<win-asp-core-iisDbContext> options)
            : base(options)
        {
        }
    }
}

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using win-asp-core-iis.Configuration;
using win-asp-core-iis.Web;

namespace win-asp-core-iis.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class win-asp-core-iisDbContextFactory : IDesignTimeDbContextFactory<win-asp-core-iisDbContext>
    {
        public win-asp-core-iisDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<win-asp-core-iisDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            win-asp-core-iisDbContextConfigurer.Configure(builder, configuration.GetConnectionString(win-asp-core-iisConsts.ConnectionStringName));

            return new win-asp-core-iisDbContext(builder.Options);
        }
    }
}

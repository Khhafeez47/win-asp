using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using win-asp-core-iis.Configuration;

namespace win-asp-core-iis.Web.Host.Startup
{
    [DependsOn(
       typeof(win-asp-core-iisWebCoreModule))]
    public class win-asp-core-iisWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public win-asp-core-iisWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(win-asp-core-iisWebHostModule).GetAssembly());
        }
    }
}

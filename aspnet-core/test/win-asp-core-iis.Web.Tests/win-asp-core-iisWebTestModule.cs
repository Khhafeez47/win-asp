using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using win-asp-core-iis.EntityFrameworkCore;
using win-asp-core-iis.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace win-asp-core-iis.Web.Tests
{
    [DependsOn(
        typeof(win-asp-core-iisWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class win-asp-core-iisWebTestModule : AbpModule
    {
        public win-asp-core-iisWebTestModule(win-asp-core-iisEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(win-asp-core-iisWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(win-asp-core-iisWebMvcModule).Assembly);
        }
    }
}
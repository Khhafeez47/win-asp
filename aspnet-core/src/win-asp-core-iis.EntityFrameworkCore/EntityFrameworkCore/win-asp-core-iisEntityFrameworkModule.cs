using Abp.EntityFrameworkCore.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Abp.Zero.EntityFrameworkCore;
using win-asp-core-iis.EntityFrameworkCore.Seed;

namespace win-asp-core-iis.EntityFrameworkCore
{
    [DependsOn(
        typeof(win-asp-core-iisCoreModule), 
        typeof(AbpZeroCoreEntityFrameworkCoreModule))]
    public class win-asp-core-iisEntityFrameworkModule : AbpModule
    {
        /* Used it tests to skip dbcontext registration, in order to use in-memory database of EF Core */
        public bool SkipDbContextRegistration { get; set; }

        public bool SkipDbSeed { get; set; }

        public override void PreInitialize()
        {
            if (!SkipDbContextRegistration)
            {
                Configuration.Modules.AbpEfCore().AddDbContext<win-asp-core-iisDbContext>(options =>
                {
                    if (options.ExistingConnection != null)
                    {
                        win-asp-core-iisDbContextConfigurer.Configure(options.DbContextOptions, options.ExistingConnection);
                    }
                    else
                    {
                        win-asp-core-iisDbContextConfigurer.Configure(options.DbContextOptions, options.ConnectionString);
                    }
                });
            }
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(win-asp-core-iisEntityFrameworkModule).GetAssembly());
        }

        public override void PostInitialize()
        {
            if (!SkipDbSeed)
            {
                SeedHelper.SeedHostDb(IocManager);
            }
        }
    }
}

using Microsoft.Extensions.Configuration;
using Castle.MicroKernel.Registration;
using Abp.Events.Bus;
using Abp.Modules;
using Abp.Reflection.Extensions;
using win-asp-core-iis.Configuration;
using win-asp-core-iis.EntityFrameworkCore;
using win-asp-core-iis.Migrator.DependencyInjection;

namespace win-asp-core-iis.Migrator
{
    [DependsOn(typeof(win-asp-core-iisEntityFrameworkModule))]
    public class win-asp-core-iisMigratorModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public win-asp-core-iisMigratorModule(win-asp-core-iisEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbSeed = true;

            _appConfiguration = AppConfigurations.Get(
                typeof(win-asp-core-iisMigratorModule).GetAssembly().GetDirectoryPathOrNull()
            );
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(
                win-asp-core-iisConsts.ConnectionStringName
            );

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
            Configuration.ReplaceService(
                typeof(IEventBus), 
                () => IocManager.IocContainer.Register(
                    Component.For<IEventBus>().Instance(NullEventBus.Instance)
                )
            );
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(win-asp-core-iisMigratorModule).GetAssembly());
            ServiceCollectionRegistrar.Register(IocManager);
        }
    }
}

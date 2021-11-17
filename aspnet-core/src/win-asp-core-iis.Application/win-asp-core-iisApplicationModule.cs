using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using win-asp-core-iis.Authorization;

namespace win-asp-core-iis
{
    [DependsOn(
        typeof(win-asp-core-iisCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class win-asp-core-iisApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<win-asp-core-iisAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(win-asp-core-iisApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}

using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Shertech001.Authorization;

namespace Shertech001
{
    [DependsOn(
        typeof(Shertech001CoreModule), 
        typeof(AbpAutoMapperModule))]
    public class Shertech001ApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<Shertech001AuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(Shertech001ApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}

using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ThinkAM.Sites.Authorization;

namespace ThinkAM.Sites
{
    [DependsOn(
        typeof(SitesCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class SitesApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<SitesAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(SitesApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}

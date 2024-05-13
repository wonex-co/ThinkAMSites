using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ThinkAM.Sites.Configuration;

namespace ThinkAM.Sites.Web.Host.Startup
{
    [DependsOn(
       typeof(SitesWebCoreModule))]
    public class SitesWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public SitesWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(SitesWebHostModule).GetAssembly());
        }
    }
}

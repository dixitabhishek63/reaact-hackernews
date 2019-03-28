using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Shertech001.Configuration;

namespace Shertech001.Web.Host.Startup
{
    [DependsOn(
       typeof(Shertech001WebCoreModule))]
    public class Shertech001WebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public Shertech001WebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(Shertech001WebHostModule).GetAssembly());
        }
    }
}

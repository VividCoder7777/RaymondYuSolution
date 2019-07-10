using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using RaymondYuSolution.Configuration;

namespace RaymondYuSolution.Web.Host.Startup
{
    [DependsOn(
       typeof(RaymondYuSolutionWebCoreModule))]
    public class RaymondYuSolutionWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public RaymondYuSolutionWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(RaymondYuSolutionWebHostModule).GetAssembly());
        }
    }
}

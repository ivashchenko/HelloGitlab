using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using HelloGitlab.Configuration;

namespace HelloGitlab.Web.Host.Startup
{
    [DependsOn(
       typeof(HelloGitlabWebCoreModule))]
    public class HelloGitlabWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public HelloGitlabWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(HelloGitlabWebHostModule).GetAssembly());
        }
    }
}

using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using HelloGitlab.Authorization;

namespace HelloGitlab
{
    [DependsOn(
        typeof(HelloGitlabCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class HelloGitlabApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<HelloGitlabAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(HelloGitlabApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}

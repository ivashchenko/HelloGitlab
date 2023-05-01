using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using HelloGitlab.EntityFrameworkCore;
using HelloGitlab.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace HelloGitlab.Web.Tests
{
    [DependsOn(
        typeof(HelloGitlabWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class HelloGitlabWebTestModule : AbpModule
    {
        public HelloGitlabWebTestModule(HelloGitlabEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(HelloGitlabWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(HelloGitlabWebMvcModule).Assembly);
        }
    }
}
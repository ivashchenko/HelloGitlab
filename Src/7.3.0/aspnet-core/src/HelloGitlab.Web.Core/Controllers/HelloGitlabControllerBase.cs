using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace HelloGitlab.Controllers
{
    public abstract class HelloGitlabControllerBase: AbpController
    {
        protected HelloGitlabControllerBase()
        {
            LocalizationSourceName = HelloGitlabConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}

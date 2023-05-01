using Abp.AspNetCore.Mvc.ViewComponents;

namespace HelloGitlab.Web.Views
{
    public abstract class HelloGitlabViewComponent : AbpViewComponent
    {
        protected HelloGitlabViewComponent()
        {
            LocalizationSourceName = HelloGitlabConsts.LocalizationSourceName;
        }
    }
}

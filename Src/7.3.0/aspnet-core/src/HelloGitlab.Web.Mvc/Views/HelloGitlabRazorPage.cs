using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;
using Microsoft.AspNetCore.Mvc.Razor.Internal;

namespace HelloGitlab.Web.Views
{
    public abstract class HelloGitlabRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected HelloGitlabRazorPage()
        {
            LocalizationSourceName = HelloGitlabConsts.LocalizationSourceName;
        }
    }
}

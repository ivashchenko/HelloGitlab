using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using HelloGitlab.Controllers;

namespace HelloGitlab.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : HelloGitlabControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}

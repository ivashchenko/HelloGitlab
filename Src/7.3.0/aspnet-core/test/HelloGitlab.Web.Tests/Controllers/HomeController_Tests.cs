using System.Threading.Tasks;
using HelloGitlab.Models.TokenAuth;
using HelloGitlab.Web.Controllers;
using Shouldly;
using Xunit;

namespace HelloGitlab.Web.Tests.Controllers
{
    public class HomeController_Tests: HelloGitlabWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            await AuthenticateAsync(null, new AuthenticateModel
            {
                UserNameOrEmailAddress = "admin",
                Password = "123qwe"
            });

            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}
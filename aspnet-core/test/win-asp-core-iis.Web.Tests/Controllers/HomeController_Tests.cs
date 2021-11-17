using System.Threading.Tasks;
using win-asp-core-iis.Models.TokenAuth;
using win-asp-core-iis.Web.Controllers;
using Shouldly;
using Xunit;

namespace win-asp-core-iis.Web.Tests.Controllers
{
    public class HomeController_Tests: win-asp-core-iisWebTestBase
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
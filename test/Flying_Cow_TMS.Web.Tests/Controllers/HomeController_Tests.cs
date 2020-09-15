using System.Threading.Tasks;
using Flying_Cow_TMS.Models.TokenAuth;
using Flying_Cow_TMS.Web.Controllers;
using Shouldly;
using Xunit;

namespace Flying_Cow_TMS.Web.Tests.Controllers
{
    public class HomeController_Tests: Flying_Cow_TMSWebTestBase
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
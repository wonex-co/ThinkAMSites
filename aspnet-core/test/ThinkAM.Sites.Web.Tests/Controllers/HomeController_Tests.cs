﻿using System.Threading.Tasks;
using ThinkAM.Sites.Models.TokenAuth;
using ThinkAM.Sites.Web.Controllers;
using Shouldly;
using Xunit;

namespace ThinkAM.Sites.Web.Tests.Controllers
{
    public class HomeController_Tests: SitesWebTestBase
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
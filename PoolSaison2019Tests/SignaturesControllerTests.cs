using Microsoft.AspNetCore.Mvc;
using PoolSaison2019.Controllers;
using PoolSaison2019.Data;
using PoolSaison2019.Models;
using System;
using System.Threading.Tasks;
using Xunit;

namespace PoolSaison2019Tests
{
    public class SignaturesControllerTests
    {
        MockSignatureRepository mockRepo;
        SignaturesController controller;
        public SignaturesControllerTests()
        {
            mockRepo = new MockSignatureRepository();
            controller = new SignaturesController(mockRepo);
        }

        [Fact]
        public async Task Test_Index_Returns_A_ViewResult()
        {
            var result = await controller.Index();

            var viewResult = Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public async Task Index_Last_Signature_Should_Be_In_View()
        {
            var result = await controller.Index();

            var viewResult = Assert.IsType<ViewResult>(result);
            Assert.Equal(mockRepo._signatures[mockRepo._signatures.Count - 1], viewResult.ViewData.Model);
        }
    }
}

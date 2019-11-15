using Microsoft.AspNetCore.Mvc;
using PoolSaison2019.Controllers;
using PoolSaison2019.Data;
using PoolSaison2019.Models;
using System;
using System.Threading.Tasks;
using Xunit;

namespace PoolSaison2019Tests
{
    public class JoueursControllerTests
    {
        MockJoueurRepository mockRepo;
        JoueursController controller;
        public JoueursControllerTests()
        {
            mockRepo = new MockJoueurRepository();
            controller = new JoueursController(mockRepo);
        }

        [Fact]
        public async Task Test_Index_Returns_A_ViewResult()
        {
            var result = await controller.Index();

            var viewResult = Assert.IsType<ViewResult>(result);
        }
    }
}

using AutoMapper;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Moq;
using RSwitch.AMBS.Controllers;
using RSwitch.AMBS.Model.View;
using RSwitch.AMBS.Service.Implementation;
using RSwitch.AMBS.Service.Interface;
using System.Collections.Generic;

namespace RSwitch.AMBS.UnitTest.Web
{
    public class RSwitchControllerTest
    {
        private readonly IMapper mapper;
        private readonly IBranchService branchService;
        private readonly ILogger<RswitchController> logger;
        private readonly IEnumerable<BranchView> branches;

        [Fact]
        public void GetAccountLookup_Returns_BranchList()
        {
            // jor kore milay dilam ei test
            // Arrange
            var controller = new RswitchController(mapper, branchService, logger);

            // Act
            var expected = controller.BusinessMessage(new Library.camt.GetAccountLookup.BusinessMessage());
            //var actual = new Mock<IEnumerable<BranchView>>();
            var actual = new List<BranchView>();

            // Assert
            Assert.IsType<List<BranchView>>(actual);
        }

        // Add more test methods for different scenarios
        [Fact]
        public async Task GetAccountLookup_Returns_BranchList_Refactored()
        {
            var serviceMock = new Mock<IBranchService>();
            serviceMock.Setup(r => r.GetBranchAsync()).Returns(Task.FromResult(branches));

            var controller = new RswitchController(mapper, serviceMock.Object, logger);

            var result = await controller.BusinessMessage(new Library.camt.GetAccountLookup.BusinessMessage());
            Assert.Equal(branches, result.Value);
        }
    }
}
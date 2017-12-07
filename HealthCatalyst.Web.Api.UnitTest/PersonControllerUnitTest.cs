using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Xunit;

using Moq;

using HealthCatalyst.Services;
using HealthCatalyst.Services.Models;
using HealthCatalyst.Web.Api.Controllers;

namespace HealthCatalyst.Web.Api.UnitTest
{
    public class PersonControllerUnitTest
    {
        [Fact]
        public async void SearchByName_ReturnsOkWithResult()
        {
            // Arrange
            var mockPersonSearchService = new Mock<IPersonSearchService>();
            var personResults = new List<PersonResult>();
            personResults.Add(new PersonResult { Name = "name" });
            mockPersonSearchService.Setup(foo => foo.SearchByName(It.IsAny<string>()))
                                   .Returns(Task.FromResult(personResults));

            var mockPersonDataSeederService = new Mock<IPersonDataSeederService>();



            var sut = new PersonController(mockPersonSearchService.Object,
                                           mockPersonDataSeederService.Object);

            // Act
            var ret = await sut.SearchByName("anySearchString");

            // Assert
            var okResult = Assert.IsType<OkObjectResult>(ret);

            var retValue = Assert.IsType<List<PersonResult>>(okResult.Value);
            Assert.Equal(1, retValue.Count());
        }

        [Fact]
        public async void SearchByName_NullReturnsBadRequest()
        {
            // Arrange
            var mockPersonSearchService = new Mock<IPersonSearchService>();
            var personResults = new List<PersonResult>();
            personResults.Add(new PersonResult { Name = "name" });
            mockPersonSearchService.Setup(foo => foo.SearchByName(It.IsAny<string>()))
                                   .Returns(Task.FromResult(personResults));

            var mockPersonDataSeederService = new Mock<IPersonDataSeederService>();

            var sut = new PersonController(mockPersonSearchService.Object,
                                           mockPersonDataSeederService.Object);

            // Act
            var ret = await sut.SearchByName(null); 

            // Assert
            var badRequestResult = Assert.IsType<BadRequestObjectResult>(ret);
        }

        [Fact]
        public async void SearchByName_IsEmptyStringReturnsBadRequest()
        {
            // Arrange
            var mockPersonSearchService = new Mock<IPersonSearchService>();
            var personResults = new List<PersonResult>();
            personResults.Add(new PersonResult { Name = "name" });
            mockPersonSearchService.Setup(foo => foo.SearchByName(It.IsAny<string>()))
                                   .Returns(Task.FromResult(personResults));

            var mockPersonDataSeederService = new Mock<IPersonDataSeederService>();

            var sut = new PersonController(mockPersonSearchService.Object,
                                           mockPersonDataSeederService.Object);

            // Act
            var ret = await sut.SearchByName(string.Empty);

            // Assert
            var badRequestResult = Assert.IsType<BadRequestObjectResult>(ret);
        }
    }
}

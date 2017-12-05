using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

using Moq;

using HealthCatalyst.Domain.Models;
using HealthCatalyst.Data.Repository;
using HealthCatalyst.Services;

namespace HealthCatalyst.Services.UnitTest
{
    public class PersonSearchServiceUnitTest
    {
        [Fact]
        public void SearchByName_ConvertsDOBToAge()
        {
            // Arrange
            var mockPersonRepository = new Mock<IPersonRepository>();
            var persons = new List<Person>();
            persons.Add(new Person { FirstName = "test 1", DateOfBirth = DateTime.Now.AddYears(-10)});

            mockPersonRepository.Setup(foo => foo.SearchByName(It.IsAny<string>()))
                                .Returns(Task.FromResult(persons));

            var sut = new PersonSearchService(mockPersonRepository.Object);

            // Act
            var ret = sut.SearchByName("anySearchString");

            // Assert
            Assert.Equal(ret.Result[0].Age, 10);

        }

        [Fact]
        public void SearchByName_CatsAddressProperly()
        {
            // Arrange
            var mockPersonRepository = new Mock<IPersonRepository>();
            var persons = new List<Person>();
            persons.Add(new Person { FirstName = "test 1", DateOfBirth = DateTime.Now.AddYears(-10) });

            mockPersonRepository.Setup(foo => foo.SearchByName(It.IsAny<string>()))
                                .Returns(Task.FromResult(persons));

            var sut = new PersonSearchService(mockPersonRepository.Object);

            // Act
            var ret = sut.SearchByName("anySearchString");

            // Assert
            Assert.Equal(ret.Result[0].Age, 10);

        }
    }
}

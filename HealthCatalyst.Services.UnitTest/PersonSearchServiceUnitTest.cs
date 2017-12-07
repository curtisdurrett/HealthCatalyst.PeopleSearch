using Moq;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

using HealthCatalyst.Domain.Models;
using HealthCatalyst.Data.Repository;

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
        public void SearchByName_CatsNameProperly()
        {
            // Arrange
            var mockPersonRepository = new Mock<IPersonRepository>();
            var persons = new List<Person>();
            var person1 = new Person
            {
                FirstName = "FN1",
                LastName = "LN1",
            };
            persons.Add(person1);

            mockPersonRepository.Setup(foo => foo.SearchByName(It.IsAny<string>()))
                                .Returns(Task.FromResult(persons));

            var sut = new PersonSearchService(mockPersonRepository.Object);

            // Act
            var ret = sut.SearchByName("anySearchString");

            // Assert
            Assert.Equal(ret.Result[0].Name, "FN1 LN1");

        }

        [Fact]
        public void SearchByName_CatsAddressProperly()
        {
            // Arrange
            var mockPersonRepository = new Mock<IPersonRepository>();
            var persons = new List<Person>();
            var person1 = new Person
            {
                AddressLine1 = "AL1",
                AddressLine2 = "AL2",
                City = "City",
                State = "TX",
                Zip = "12345"
            };
            persons.Add(person1);

            mockPersonRepository.Setup(foo => foo.SearchByName(It.IsAny<string>()))
                                .Returns(Task.FromResult(persons));

            var sut = new PersonSearchService(mockPersonRepository.Object);

            // Act
            var ret = sut.SearchByName("anySearchString");

            // Assert
            Assert.Equal(ret.Result[0].Address, "AL1 AL2 City, TX 12345");

        }
    }
}

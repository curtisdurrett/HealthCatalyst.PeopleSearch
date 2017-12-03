using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using HealthCatalyst.Data.Repository;
using HealthCatalyst.Domain.Models;

using HealthCatalyst.Services.Models;

namespace HealthCatalyst.Services
{
    public class PersonSearchService : IPersonSearchService
    {
        private readonly IPersonRepository _personRepository;
        
        public PersonSearchService(IPersonRepository personRepository)
        {
            _personRepository = personRepository; 
        }

        public async Task<IList<PersonResult>> SearchByName(string searchString)
        {
            var personResults = new List<PersonResult>();
            //var x = await _personRepository.SearchByName(searchString);
            foreach (Person p in await _personRepository.SearchByName(searchString))
            {
                var personResult = new PersonResult
                {
                    Name = p.FirstName + " " + p.LastName,
                    Age = GetAge(p.DateOfBirth), 
                    PictureFileName = p.PictureFileName,
                    Address = string.Format("{0} {1} {2}, {3} {4}", p.AddressLine1, p.AddressLine2, p.City, p.State, p.Zip),
                    Interests = p.Interests
                };
                personResults.Add(personResult);
            }

            return personResults;
        }

        private Int32 GetAge(DateTime dateOfBirth)
        {
            var today = DateTime.Today;

            var a = (today.Year * 100 + today.Month) * 100 + today.Day;
            var b = (dateOfBirth.Year * 100 + dateOfBirth.Month) * 100 + dateOfBirth.Day;

            return (a - b) / 10000;
        }

    }
}

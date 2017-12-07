using System;
using System.Threading.Tasks;

using HealthCatalyst.Data.Repository;
using HealthCatalyst.Domain.Models;

namespace HealthCatalyst.Services
{
    public class PersonDataSeederService : IPersonDataSeederService
    {
        private readonly IPersonRepository _personRepository;

        public PersonDataSeederService(IPersonRepository personRepository)
        {
            _personRepository = personRepository;
        }

        public async Task<int> SeedData()
        {
            int personsDeleted;
            personsDeleted = await _personRepository.DeleteAllPersons();
            return AddSeedPeople();
        }

        private int AddSeedPeople()
        {
            int peopleAdded = 0;
            _personRepository.Add(new Person
            {
                FirstName = "Chris",
                LastName = "Peele",
                DateOfBirth = new DateTime(1974, 5, 12),
                Interests = "Old Movies and Iot",
                PictureFileName = "p2.jpg",
                AddressLine1 = "709 Pony Street",
                AddressLine2 = null,
                City = "Harker Heights",
                State = "TX",
                Zip = "76523"
            });
            peopleAdded++;

            _personRepository.Add(new Person
            {
                FirstName = "Christopher",
                LastName = "Durrett",
                DateOfBirth = new DateTime(2004, 6, 08),
                Interests = "Harry Potter, Band and Golf",
                PictureFileName = "p10.jpg",
                AddressLine1 = "3309 DeLeon Cir",
                AddressLine2 = null,
                City = "Belton",
                State = "TX",
                Zip = "76513"
            });
            peopleAdded++;

            _personRepository.Add(new Person
            {
                FirstName = "Daniel",
                LastName = "Durrett",
                DateOfBirth = new DateTime(2002, 2, 21),
                Interests = "Welding and Bikes",
                PictureFileName = "p5.jpg",
                AddressLine1 = "444 DeLeon",
                AddressLine2 = null,
                City = "Belton",
                State = "TX",
                Zip = "76513"
            });
            peopleAdded++;

            _personRepository.Add(new Person
            {
                FirstName = "Carlyn",
                LastName = "Havelka",
                DateOfBirth = new DateTime(1968, 10, 2),
                Interests = "Crossword Puzzles and Reading",
                PictureFileName = "p6.jpg",
                AddressLine1 = "709 Redrock",
                AddressLine2 = null,
                City = "Little River",
                State = "TX",
                Zip = "76523"
            });
            peopleAdded++;

            _personRepository.Add(new Person
            {
                FirstName = "Roger",
                LastName = "Hampton",
                DateOfBirth = new DateTime(1974, 12, 3),
                Interests = "Cycling and Youth Groups",
                PictureFileName = "p8.jpg",
                AddressLine1 = "554 Southfork",
                AddressLine2 = null,
                City = "Belton",
                State = "TX",
                Zip = "76523"
            });
            peopleAdded++;

            return peopleAdded;
        }
    }
}


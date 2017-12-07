using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using HealthCatalyst.Domain.Models;

namespace HealthCatalyst.Data.Repository
{
    public class PersonRepository : IPersonRepository
    {
        private readonly DatabaseContext _databaseContext;

        public PersonRepository(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }

        public void Add(Person person)
        {
            _databaseContext.Persons.Add(person);
            _databaseContext.SaveChanges();
        }

        public async Task<int> DeleteAllPersons()
        {
            int count = 0;
            var rows = from o in _databaseContext.Persons
                       select o;
            foreach (var row in rows)
            {
                _databaseContext.Persons.Remove(row);
                count++;
            }
            await _databaseContext.SaveChangesAsync();
            return count;
        }

        public async Task<List<Person>> SearchByName(string searchString)
        {

            var persons = _databaseContext.Persons
                                          .Where(p => EF.Functions.Like(p.FirstName, $"%{searchString}%") || EF.Functions.Like(p.LastName, $"%{searchString}%"));

            return await persons.ToListAsync();    
        }
    }
}

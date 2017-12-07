using System.Collections.Generic;
using System.Threading.Tasks;

using HealthCatalyst.Domain.Models;

namespace HealthCatalyst.Data.Repository
{
    public interface IPersonRepository
    {
        void Add(Person person);
        Task<int> DeleteAllPersons();
        Task<List<Person>> SearchByName(string searchString);        
    }
}

using System.Collections.Generic;
using System.Threading.Tasks;

using HealthCatalyst.Domain.Models;

namespace HealthCatalyst.Data.Repository
{
    public interface IPersonRepository
    {
        Task<IList<Person>> SearchByName(string searchString);        
    }
}

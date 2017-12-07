using System.Collections.Generic;
using System.Threading.Tasks;

using HealthCatalyst.Services.Models;

namespace HealthCatalyst.Services
{
    public interface IPersonSearchService
    {
        Task<List<PersonResult>> SearchByName(string searchString);
    }
}

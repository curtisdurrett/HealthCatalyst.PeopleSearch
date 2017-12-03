using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using HealthCatalyst.Services.Models;

namespace HealthCatalyst.Services
{
    public interface IPersonSearchService
    {
        Task<IList<PersonResult>> SearchByName(string searchString);
    }
}

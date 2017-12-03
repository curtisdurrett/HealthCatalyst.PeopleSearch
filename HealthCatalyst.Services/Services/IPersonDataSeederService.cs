using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using HealthCatalyst.Services.Models;

namespace HealthCatalyst.Services
{
    public interface IPersonDataSeederService
    {
        int SeedData();
    }
}

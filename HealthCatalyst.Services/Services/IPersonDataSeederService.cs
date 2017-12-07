using System.Threading.Tasks;

namespace HealthCatalyst.Services
{
    public interface IPersonDataSeederService
    {
        Task<int> SeedData();
    }
}

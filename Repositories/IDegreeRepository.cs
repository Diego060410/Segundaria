using Segundaria.DataModels;
using System.Threading.Tasks;

namespace Segundaria.Repositories
{
    public interface IDegreeRepository
    {
        Task<List<Degree>> GetAllAsync();
    }
}

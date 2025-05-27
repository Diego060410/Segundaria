using Segundaria.DataModels;
using System.Threading.Tasks;

namespace Segundaria.Repositories
{
    public interface ITuitionRepository
    {
        Task<List<Tuition>> GetAllAsync();
    }
}

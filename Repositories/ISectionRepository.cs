using Segundaria.DataModels;
using System.Threading.Tasks;

namespace Segundaria.Repositories
{
    public interface ISectionRepository
    {
        Task<List<Section>> GetAllAsync();
    }
}

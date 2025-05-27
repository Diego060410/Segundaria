using Segundaria.DataModels;
using System.Threading.Tasks;

namespace Segundaria.Repositories
{
    public interface IParentRepository
    {
        Task<List<Parent>> GetAllAsync();
    }
}

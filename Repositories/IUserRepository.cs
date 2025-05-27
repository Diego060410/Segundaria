using Segundaria.DataModels;
using System.Threading.Tasks;

namespace Segundaria.Repositories
{
    public interface IUserRepository
    {
        Task<List<User>> GetAllAsync();
    }
}

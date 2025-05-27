using Segundaria.DataModels;
using System.Threading.Tasks;

namespace Segundaria.Repositories
{
    public interface ITeacherRepository
    {
        Task<List<Teacher>> GetAllAsync();
    }
}

using Segundaria.DataModels;
using System.Threading.Tasks;

namespace Segundaria.Repositories
{
    public interface ICourseRepository
    {
        Task<List<Course>> GetAllAsync();
    }
}

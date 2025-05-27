using Segundaria.DataModels;
using System.Threading.Tasks;

namespace Segundaria.Repositories
{
    public interface IStudentRepository
    {
        Task<List<Student>> GetAllAsync();
    }
}

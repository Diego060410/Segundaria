using Microsoft.EntityFrameworkCore;
using Segundaria.DataModels;

namespace Segundaria.Repositories
{
    public class SqlStudentRepository : IStudentRepository
    {
        private readonly SchoolDbContext context;

        public SqlStudentRepository(SchoolDbContext context)
        {
            this.context = context;
        }

        public async Task<List<Student>> GetAllAsync()
        {
            return await context.Students.ToListAsync();
        }
    }
}

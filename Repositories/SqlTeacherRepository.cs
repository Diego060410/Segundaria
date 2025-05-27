using Microsoft.EntityFrameworkCore;
using Segundaria.DataModels;

namespace Segundaria.Repositories
{
    public class SqlTeacherRepository : ITeacherRepository
    {
        private readonly SchoolDbContext context;

        public SqlTeacherRepository(SchoolDbContext context)
        {
            this.context = context;
        }

        public async Task<List<Teacher>> GetAllAsync()
        {
            return await context.Teachers.ToListAsync();
        }
    }
}

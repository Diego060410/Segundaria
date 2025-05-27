using Microsoft.EntityFrameworkCore;
using Segundaria.DataModels;

namespace Segundaria.Repositories
{
    public class SqlCourseRepository : ICourseRepository
    {
        private readonly SchoolDbContext context;

        public SqlCourseRepository(SchoolDbContext context)
        {
            this.context = context;
        }

        public async Task<List<Course>> GetAllAsync()
        {
            return await context.Courses.ToListAsync();
        }
    }
}

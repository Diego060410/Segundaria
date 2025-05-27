using Microsoft.EntityFrameworkCore;
using Segundaria.DataModels;

namespace Segundaria.Repositories
{
    public class SqlDegreeRepository : IDegreeRepository
    {
        private readonly SchoolDbContext context;

        public SqlDegreeRepository(SchoolDbContext context)
        {
            this.context = context;
        }

        public async Task<List<Degree>> GetAllAsync()
        {
            return await context.Degrees.ToListAsync();
        }
    }
}

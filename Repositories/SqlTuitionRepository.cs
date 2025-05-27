using Microsoft.EntityFrameworkCore;
using Segundaria.DataModels;

namespace Segundaria.Repositories
{
    public class SqlTuitionRepository : ITuitionRepository
    {
        private readonly SchoolDbContext context;

        public SqlTuitionRepository(SchoolDbContext context)
        {
            this.context = context;
        }

        public async Task<List<Tuition>> GetAllAsync()
        {
            return await context.Tuitions.ToListAsync();
        }
    }
}

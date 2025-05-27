using Microsoft.EntityFrameworkCore;
using Segundaria.DataModels;

namespace Segundaria.Repositories
{
    public class SqlSectionRepository : ISectionRepository
    {
        private readonly SchoolDbContext context;

        public SqlSectionRepository(SchoolDbContext context)
        {
            this.context = context;
        }

        public async Task<List<Section>> GetAllAsync()
        {
            return await context.Sections.ToListAsync();
        }
    }
}

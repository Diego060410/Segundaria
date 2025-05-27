using Microsoft.EntityFrameworkCore;
using Segundaria.DataModels;

namespace Segundaria.Repositories
{
    public class SqlParentRepository : IParentRepository
    {
        private readonly SchoolDbContext context;

        public SqlParentRepository(SchoolDbContext context)
        {
            this.context = context;
        }

        public async Task<List<Parent>> GetAllAsync()
        {
            return await context.Parents.ToListAsync();
        }
    }
}

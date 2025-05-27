using Microsoft.EntityFrameworkCore;
using Segundaria.DataModels;

namespace Segundaria.Repositories
{
    public class SqlUserRepository : IUserRepository
    {
        private readonly SchoolDbContext context;

        public SqlUserRepository(SchoolDbContext context)
        {
            this.context = context;
        }

        public async Task<List<User>> GetAllAsync()
        {
            return await context.Users.ToListAsync();
        }
    }
}

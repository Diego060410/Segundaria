using Microsoft.EntityFrameworkCore;

namespace Segundaria.DataModels
{
    public class SchoolDbContext:DbContext
    {
        public SchoolDbContext(DbContextOptions<SchoolDbContext> options) : base(options) { }

        // Entidades académicas
        public DbSet<Course> Courses { get; set; }
        public DbSet<Degree> Degrees { get; set; }
        public DbSet<Parent> Parents { get; set; }
        public DbSet<Section> Sections { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Tuition> Tuitions { get; set; }
        public DbSet<User> Users { get; set; }
    }
}

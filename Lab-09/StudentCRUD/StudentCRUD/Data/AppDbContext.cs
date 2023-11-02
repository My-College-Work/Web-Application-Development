using Microsoft.EntityFrameworkCore;
using StudentCRUD.Models.Domain;

namespace StudentCRUD.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options) { }

        public DbSet<Student> Students { get; set; }
    }
}

using Microsoft.EntityFrameworkCore;
using myapp.Models; // Replace with your actual namespace

namespace myapp.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Todo> Todos { get; set; }
    }
}

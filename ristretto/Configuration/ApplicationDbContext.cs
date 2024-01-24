using Microsoft.EntityFrameworkCore;
using ristretto.Entities;
using System.Runtime.CompilerServices;

namespace ristretto.Configuration
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Company> Companies { get; set; }
        public DbSet<Employee> Employees { get; set; }
    }
}

using Microsoft.EntityFrameworkCore;
using ristretto.Entities;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace ristretto.Configuration
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Company> Companies { get; set; }
        public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            _ = modelBuilder ?? throw new ArgumentNullException(nameof(modelBuilder));

            _ = modelBuilder.HasDefaultSchema("ristretto");

            _ = modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            base.OnModelCreating(modelBuilder);
        }
    }
}

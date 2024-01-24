using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ristretto.Entities
{
    public sealed partial class Employee
    {
        public sealed class EntityTypeConfigurationAttribute : IEntityTypeConfiguration<Employee>
        {
            public void Configure(EntityTypeBuilder<Employee> builder)
            {
                _ = builder.ToTable("funcionarios", "ristretto");
                _ = builder.HasKey(e => e.Id);

                _ = builder.Property(e => e.Name).HasColumnName("nome");
                _ = builder.Property(e => e.Email).HasColumnName("email");
                _ = builder.Property(e => e.JobRole).HasColumnName("cargo");
                _ = builder.Property(e => e.DateOfBirth).HasColumnName("data_de_nascimento");
                _ = builder.Property(e => e.Login).HasColumnName("login");
                _ = builder.Property(e => e.Password).HasColumnName("senha");

                _ = builder.HasOne<Company>(e => e.Company).WithMany().HasForeignKey(c => c.Company.Id);
            }

        }
    }
}

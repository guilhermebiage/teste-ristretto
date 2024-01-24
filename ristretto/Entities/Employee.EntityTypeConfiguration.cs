using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ristretto.Entities
{
    public partial class Employee : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            _ = builder.ToTable("FUNCIONARIOS");
            _ = builder.HasKey(e => e.Id);

            _ = builder.Property(e => e.Name).HasColumnName("NOME");
            _ = builder.Property(e => e.Email).HasColumnName("EMAIL");
            _ = builder.Property(e => e.JobRole).HasColumnName("CARGO");
            _ = builder.Property(e => e.DateOfBirth).HasColumnName("DATA_DE_NASCIMENTO");
            _ = builder.Property(e => e.Login).HasColumnName("LOGIN");
            _ = builder.Property(e => e.Password).HasColumnName("SENHA");

            _ = builder.HasOne<Company>(e => e.Company).WithMany(c => c.Employees);
        }
    }
}

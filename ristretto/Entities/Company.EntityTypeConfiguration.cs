using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ristretto.Entities
{
    public sealed partial class Company
    {
        public sealed class EntityTypeConfiguration : IEntityTypeConfiguration<Company>
        {
            public void Configure(EntityTypeBuilder<Company> builder)
            {
                _ = builder.ToTable("empresas", "ristretto");
                _ = builder.HasKey(c => c.Id);

                _ = builder.Property(c => c.Id).HasColumnName("id");
                _ = builder.Property(c => c.Name).HasColumnName("nome").IsRequired();
                _ = builder.Property(c => c.PhoneNumber).HasColumnName("telefone").IsRequired();
                _ = builder.Property(c => c.Url).HasColumnName("url");
                _ = builder.HasMany<Employee>(c => c.Employees).WithOne(e => e.Company);
            }
        }
    }
}

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ristretto.Entities
{
    public partial class Company : IEntityTypeConfiguration<Company>
    {
        public void Configure(EntityTypeBuilder<Company> builder)
        {
            _ = builder.ToTable("EMPRESAS");
            _ = builder.HasKey(c => c.Id);

            _ = builder.Property(c => c.Id).HasColumnName("ID");
            _ = builder.Property(c => c.Name).HasColumnName("NOME").IsRequired();
            _ = builder.Property(c => c.PhoneNumber).HasColumnName("TELEFONE").IsRequired();
            _ = builder.Property(c => c.Url).HasColumnName("URL");
            _ = builder.HasMany<Employee>(c => c.Employees).WithOne(e => e.Company);
        }
    }
}

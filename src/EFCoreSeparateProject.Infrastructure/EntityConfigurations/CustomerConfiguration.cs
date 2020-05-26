using EFCoreSeparateProject.Core.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCoreSeparateProject.Infrastructure.EntityConfigurations
{
    public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.OwnsOne(e => e.Address, t =>
            {
                t.OwnsOne(a => a.Line1).Property(e => e.Line).HasColumnName("AddressLine1");
                t.OwnsOne(a => a.Line2).Property(e => e.Line).HasColumnName("AddressLine2");
                t.OwnsOne(a => a.Postcode).Property(e => e.Postcode).HasColumnName("Postcode");
            });
        }
    }
}

using EFCoreSeparateProject.Core.Domain;
using EFCoreSeparateProject.Infrastructure.EntityConfigurations;
using Microsoft.EntityFrameworkCore;

namespace EFCoreSeparateProject.Infrastructure
{
    public class ExampleDbContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> CustomerOrders { get; set; }
        public ExampleDbContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.HasDefaultSchema("EfCore");
            builder.ApplyConfiguration(new CustomerConfiguration());
        }
    }
}

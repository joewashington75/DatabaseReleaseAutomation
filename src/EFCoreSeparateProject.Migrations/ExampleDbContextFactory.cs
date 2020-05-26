using EFCoreSeparateProject.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace EFCoreSeparateProject.Migrations
{
    public class ExampleDbContextFactory : IDesignTimeDbContextFactory<ExampleDbContext>
    {
        public ExampleDbContext CreateDbContext(string[] args)
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", true)
                .AddEnvironmentVariables()
                .AddCommandLine(args)
                .Build();

            var optionsBuilder = new DbContextOptionsBuilder<ExampleDbContext>();
            optionsBuilder.UseSqlServer(configuration.GetValue<string>("ConnectionStrings:SqlConnectionString"), x => x.MigrationsAssembly("EFCoreSeparateProject.Migrations"));

            return new ExampleDbContext(optionsBuilder.Options);
        }
    }
}
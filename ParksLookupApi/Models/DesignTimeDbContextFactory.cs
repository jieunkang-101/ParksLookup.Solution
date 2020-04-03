using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace ParksLookupApi.Models
{
  public class ParksLookupApiContextFactory : IDesignTimeDbContextFactory<ParksLookupApiContext>
  {

    ParksLookupApiContext IDesignTimeDbContextFactory<ParksLookupApiContext>.CreateDbContext(string[] args)
    {
      IConfigurationRoot configuration = new ConfigurationBuilder()
          .SetBasePath(Directory.GetCurrentDirectory())
          .AddJsonFile("appsettings.json")
          .Build();

      var builder = new DbContextOptionsBuilder<ParksLookupApiContext>();
      var connectionString = configuration.GetConnectionString("DefaultConnection");

      builder.UseMySql(connectionString);

      return new ParksLookupApiContext(builder.Options);
    }
  }
}
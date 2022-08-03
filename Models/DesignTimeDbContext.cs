using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace UniversityRoster.Models
{
  public class UniversityRosterContextFactory : IDesignTimeDbContextFactory<UniversityRosterContext>
  {

    UniversityRosterContext IDesignTimeDbContextFactory<UniversityRosterContext>.CreateDbContext(string[] args)
    {
      IConfigurationRoot configuration = new ConfigurationBuilder()
          .SetBasePath(Directory.GetCurrentDirectory())
          .AddJsonFile("appsettings.json")
          .Build();

      var builder = new DbContextOptionsBuilder<UniversityRosterContext>();

      builder.UseMySql(configuration["ConnectionStrings:DefaultConnection"], ServerVersion.AutoDetect(configuration["ConnectionStrings:DefaultConnection"]));

      return new UniversityRosterContext(builder.Options);
    }
  }
}
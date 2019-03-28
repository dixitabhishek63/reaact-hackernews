using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Shertech001.Configuration;
using Shertech001.Web;

namespace Shertech001.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class Shertech001DbContextFactory : IDesignTimeDbContextFactory<Shertech001DbContext>
    {
        public Shertech001DbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<Shertech001DbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            Shertech001DbContextConfigurer.Configure(builder, configuration.GetConnectionString(Shertech001Consts.ConnectionStringName));

            return new Shertech001DbContext(builder.Options);
        }
    }
}

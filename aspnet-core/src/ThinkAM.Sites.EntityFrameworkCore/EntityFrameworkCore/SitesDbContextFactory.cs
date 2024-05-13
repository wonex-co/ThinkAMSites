using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using ThinkAM.Sites.Configuration;
using ThinkAM.Sites.Web;

namespace ThinkAM.Sites.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class SitesDbContextFactory : IDesignTimeDbContextFactory<SitesDbContext>
    {
        public SitesDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<SitesDbContext>();
            
            /*
             You can provide an environmentName parameter to the AppConfigurations.Get method. 
             In this case, AppConfigurations will try to read appsettings.{environmentName}.json.
             Use Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") method or from string[] args to get environment if necessary.
             https://docs.microsoft.com/en-us/ef/core/cli/dbcontext-creation?tabs=dotnet-core-cli#args
             */
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            SitesDbContextConfigurer.Configure(builder, configuration.GetConnectionString(SitesConsts.ConnectionStringName));

            return new SitesDbContext(builder.Options);
        }
    }
}

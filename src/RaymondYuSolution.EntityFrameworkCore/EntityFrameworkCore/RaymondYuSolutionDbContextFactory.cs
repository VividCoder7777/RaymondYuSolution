using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using RaymondYuSolution.Configuration;
using RaymondYuSolution.Web;

namespace RaymondYuSolution.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class RaymondYuSolutionDbContextFactory : IDesignTimeDbContextFactory<RaymondYuSolutionDbContext>
    {
        public RaymondYuSolutionDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<RaymondYuSolutionDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            RaymondYuSolutionDbContextConfigurer.Configure(builder, configuration.GetConnectionString(RaymondYuSolutionConsts.ConnectionStringName));

            return new RaymondYuSolutionDbContext(builder.Options);
        }
    }
}

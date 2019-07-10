using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace RaymondYuSolution.EntityFrameworkCore
{
    public static class RaymondYuSolutionDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<RaymondYuSolutionDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<RaymondYuSolutionDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}

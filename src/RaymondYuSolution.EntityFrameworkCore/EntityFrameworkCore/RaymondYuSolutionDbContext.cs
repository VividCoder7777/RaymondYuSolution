using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using RaymondYuSolution.Authorization.Roles;
using RaymondYuSolution.Authorization.Users;
using RaymondYuSolution.MultiTenancy;

namespace RaymondYuSolution.EntityFrameworkCore
{
    public class RaymondYuSolutionDbContext : AbpZeroDbContext<Tenant, Role, User, RaymondYuSolutionDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public RaymondYuSolutionDbContext(DbContextOptions<RaymondYuSolutionDbContext> options)
            : base(options)
        {
        }
    }
}

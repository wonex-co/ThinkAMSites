using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using ThinkAM.Sites.Authorization.Roles;
using ThinkAM.Sites.Authorization.Users;
using ThinkAM.Sites.MultiTenancy;

namespace ThinkAM.Sites.EntityFrameworkCore
{
    public class SitesDbContext : AbpZeroDbContext<Tenant, Role, User, SitesDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public SitesDbContext(DbContextOptions<SitesDbContext> options)
            : base(options)
        {
        }
    }
}

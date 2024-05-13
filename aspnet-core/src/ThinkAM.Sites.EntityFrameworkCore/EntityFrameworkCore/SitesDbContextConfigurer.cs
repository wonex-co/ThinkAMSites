using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace ThinkAM.Sites.EntityFrameworkCore
{
    public static class SitesDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<SitesDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<SitesDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}

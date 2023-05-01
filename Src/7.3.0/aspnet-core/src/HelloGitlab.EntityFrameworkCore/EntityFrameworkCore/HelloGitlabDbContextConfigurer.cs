using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace HelloGitlab.EntityFrameworkCore
{
    public static class HelloGitlabDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<HelloGitlabDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<HelloGitlabDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}

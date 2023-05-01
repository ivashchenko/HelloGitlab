using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using HelloGitlab.Authorization.Roles;
using HelloGitlab.Authorization.Users;
using HelloGitlab.MultiTenancy;

namespace HelloGitlab.EntityFrameworkCore
{
    public class HelloGitlabDbContext : AbpZeroDbContext<Tenant, Role, User, HelloGitlabDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public HelloGitlabDbContext(DbContextOptions<HelloGitlabDbContext> options)
            : base(options)
        {
        }
    }
}

using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Shertech001.Authorization.Roles;
using Shertech001.Authorization.Users;
using Shertech001.MultiTenancy;

namespace Shertech001.EntityFrameworkCore
{
    public class Shertech001DbContext : AbpZeroDbContext<Tenant, Role, User, Shertech001DbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public Shertech001DbContext(DbContextOptions<Shertech001DbContext> options)
            : base(options)
        {
        }
    }
}

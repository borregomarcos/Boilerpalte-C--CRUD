using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using boilerplate.Authorization.Roles;
using boilerplate.Authorization.Users;
using boilerplate.MultiTenancy;
using boilerplate.Models;

namespace boilerplate.EntityFrameworkCore
{
    public class boilerplateDbContext : AbpZeroDbContext<Tenant, Role, User, boilerplateDbContext>
    {
        /* Define a DbSet for each entity of the application */
        public DbSet<Person> Persons { get; set; }               
        
        public boilerplateDbContext(DbContextOptions<boilerplateDbContext> options)
            : base(options)
        {
        }
    }
}

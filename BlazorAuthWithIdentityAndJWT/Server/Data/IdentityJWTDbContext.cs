using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using BlazorAuthWithIdentityAndJWT.Server.Configurations;

namespace BlazorAuthWithIdentityAndJWT.Server.Data
{
    public class IdentityJWTDbContext : IdentityDbContext<User>
    {
        public IdentityJWTDbContext(DbContextOptions options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new RoleConfiguration());
            modelBuilder.ApplyConfiguration(new DefaultUsersConfiguration());
            modelBuilder.ApplyConfiguration(new UsersRolesConfiguration());
        }
    }
}

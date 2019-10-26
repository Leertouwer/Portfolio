using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.IO;

namespace IdentityData
{
    public class IdContext : IdentityDbContext<ApplicationUser, ApplicationRole, Guid>
    {
        public IdContext(DbContextOptions<IdContext> options): base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var builder = new ConfigurationBuilder()
                        .SetBasePath(Directory.GetCurrentDirectory())
                        .AddJsonFile("appsettings.json");
                var configuration = builder.Build();
                optionsBuilder.UseSqlServer(configuration.GetConnectionString("IdContext"), b => b.MigrationsAssembly("Schaak").MigrationsHistoryTable("MigrationIdContext"));
            }
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<IdentityUserRole<Guid>>().ToTable("UserRole");
            builder.Entity<ApplicationUser>().ToTable("User");
            builder.Entity<ApplicationRole>().ToTable("Role");
            builder.Entity<IdentityUserClaim<Guid>>().ToTable("UserClaim");
            builder.Entity<IdentityRoleClaim<Guid>>().ToTable("RoleClaim");
            builder.Entity<IdentityUserLogin<Guid>>().ToTable("UserLogin");
            builder.Entity<IdentityUserToken<Guid>>().ToTable("UserToken");
            builder.Entity<ApplicationUser>().Ignore(b => b.Admin);
        }
    }
}

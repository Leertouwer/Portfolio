using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.ComponentModel.DataAnnotations;
using System.IO;

namespace SchaakData
{
    public class ApplContext:DbContext
    {
        public ApplContext(DbContextOptions<ApplContext> options)
           : base(options)
        {
        }

        public DbSet<Tournement> Tournement { get; set; }
        public DbSet<Contestent> Contestent { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var builder = new ConfigurationBuilder()
                        .SetBasePath(Directory.GetCurrentDirectory())
                        .AddJsonFile("appsettings.json");

                var configuration = builder.Build();
               // optionsBuilder.UseSqlServer(configuration.GetConnectionString("AppContext"));
                optionsBuilder.UseSqlServer( configuration.GetConnectionString("ApplContext"), b => b.MigrationsAssembly("Schaak").MigrationsHistoryTable("MigrationAppContext"));
            }
        }
    }
}

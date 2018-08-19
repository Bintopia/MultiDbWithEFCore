using BinZone.Sample.EF.MultiDB.Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace BinZone.Sample.EF.MultiDB.Data
{
    public class IdentityContext : DbContext
    {
        public IdentityContext(DbContextOptions<IdentityContext> options)
          : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ApplicationUser>().HasData(new ApplicationUser { Id = Guid.NewGuid(), Created = DateTime.UtcNow, Username = "sample@example.com", NickName = "Example", Password = "your_password" });
        }

        public DbSet<ApplicationUser> Users { get; set; }
    }
}

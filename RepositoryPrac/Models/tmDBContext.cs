
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


namespace RepositoryPrac.Models
{
    public class tmDBContext: IdentityDbContext
    {
        public tmDBContext(DbContextOptions<tmDBContext> option) : base(option)
        {
        }

        public DbSet<Status> Statuses { get; set; }
        public DbSet<ApplicationUser> applicationUsers {get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Status>().HasData(
                new Status() { Id = 5, Name = "Test1" });
        }
    }
}

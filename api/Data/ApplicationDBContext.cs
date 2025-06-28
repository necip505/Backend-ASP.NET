using Microsoft.EntityFrameworkCore; // for DbContext and DbSet 
using api.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;



namespace api.Data
{
    public class ApplicationDBContext : IdentityDbContext<AppUser>
    {
        public ApplicationDBContext(DbContextOptions dbContextOptions)
            : base(dbContextOptions)
        {

        }
        public DbSet<Stock> Stocks { get; set; }
        public DbSet<Comment> Comments { get; set; }
        
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            List<IdentityRole> roles = new List<IdentityRole>
            {
                 new IdentityRole { Id = "admin-role-id", Name = "Admin", NormalizedName = "ADMIN" },
                new IdentityRole { Id = "user-role-id", Name = "User", NormalizedName = "USER" }
            };
        builder.Entity<IdentityRole>().HasData(roles);
            
        }

    }
}
using Microsoft.EntityFrameworkCore; // for DbContext and DbSet 
using api.Models;

namespace api.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions dbContextOptions)
            : base(dbContextOptions)
        {

        }
        public DbSet<Stock> Stock { get; set; }
        public DbSet<Comment> Comment { get; set; }
    }
}
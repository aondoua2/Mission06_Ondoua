using Microsoft.EntityFrameworkCore;

namespace Mission06_Ondoua.Models
{
    public class MovieApplicationContext : DbContext
    {
        // Constructor
        public MovieApplicationContext(DbContextOptions<MovieApplicationContext> options) : base(options)
        {
        }

        // DbSet for Application entity
        public DbSet<Application> Applications { get; set; }
    }
}

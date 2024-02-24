using Microsoft.EntityFrameworkCore;

namespace Mission06_Ondoua.Models
{
    public class MovieApplicationContext : DbContext // Liaison from teh app to the DB
    {
        // Constructor
        public MovieApplicationContext(DbContextOptions<MovieApplicationContext> options) : base(options)
        {
        }

        // DbSet for Application entity
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Category> Categories{ get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);
            // go in and check if there is type for the category in the DB
            modelBuilder.Entity<Category>().HasData(
                // create the new instance of the major
                new Category { CategoryId = 1, CategoryName = "Miscellaneous" },
                new Category { CategoryId = 2, CategoryName = "Drama" },
                new Category { CategoryId = 3, CategoryName = "Television" },
                new Category { CategoryId = 4, CategoryName = "Horror/Suspense" },
                new Category { CategoryId = 5, CategoryName = "Comedy" },
                new Category { CategoryId = 6, CategoryName = "Family" },
                new Category { CategoryId = 7, CategoryName = "Action/Adventure" },
                new Category { CategoryId = 8, CategoryName = "VHS" }

                );
        }
    }
}

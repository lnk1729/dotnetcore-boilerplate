using Microsoft.EntityFrameworkCore;
using TheMovieDatabase.Models;

namespace TheMovieDatabase.Data.EFCore
{
    public class TheMovieDBContext : DbContext
    {
        public TheMovieDBContext (DbContextOptions<TheMovieDBContext> options)
            : base(options)
        {
        }

        public DbSet<Movie> Movie { get; set; }
        public DbSet<Star> Star { get; set; }
    }
}

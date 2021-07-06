using Microsoft.EntityFrameworkCore;
using WatchTogetherAPI.Models;

namespace WatchTogetherAPI.Data
{
    public class WatchTogetherContext : DbContext
    {
        public WatchTogetherContext(DbContextOptions<WatchTogetherContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movies_genres>()
                .HasKey(mg => new { mg.MovieId, mg.GenreId });
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Movies_genres> Movies_Genres{get; set;}

    }
}

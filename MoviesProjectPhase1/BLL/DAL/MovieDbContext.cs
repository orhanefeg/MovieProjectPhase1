using Microsoft.EntityFrameworkCore;

namespace YourNamespace
{
    public class MovieDbContext : DbContext
    {
        public MovieDbContext(DbContextOptions<MovieDbContext> options) : base(options)
        {
        }

        // Veritabanındaki tabloları temsil eden DbSet tanımları
        public DbSet<Movie> Movies { get; set; }
    }

    // Örnek bir tabloyu temsil eden model
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public int ReleaseYear { get; set; }
    }
}

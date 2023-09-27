using _200923PRG.Models;
using Microsoft.EntityFrameworkCore;

namespace _200923PRG.Data
{
    internal class AppDbContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Genre> Genres { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            base.OnConfiguring(builder);
            builder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=csMovies;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
            /*builder.LogTo(Console.WriteLine, new[]
            {
                RelationalEventId.CommandExecuted
            });*/
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Genre>(options =>
            {
                options.HasData(new Genre { GenreId = 1, Name = "Sci-fi" });
                options.HasData(new Genre { GenreId = 2, Name = "Horror" });
                options.HasData(new Genre { GenreId = 3, Name = "Životopis" });
            });
            modelBuilder.Entity<Movie>(options =>
            {
                options.HasData(new Movie { MovieId = 1, Name = "One Piece", Duration = 24, GenreId = 1 });
                options.HasData(new Movie { MovieId = 2, Name = "Oppenheimer", Duration = 180, GenreId = 2 });
            });
            modelBuilder.Entity<Artist>(options =>
            {
                options.HasData(new Artist { ArtistId = 1, FirstName = "Keanu", LastName = "Reeves", Gender = Gender.Male });
                options.HasData(new Artist { ArtistId = 2, FirstName = "Timothée", LastName = "Chalamet", Gender = Gender.Male });
                options.HasData(new Artist { ArtistId = 3, FirstName = string.Empty, LastName = "Zendaya", Gender = Gender.Female });
            });
        }
    }
}

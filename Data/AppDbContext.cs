using _200923PRG.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace _200923PRG.Data
{
    internal class AppDbContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            base.OnConfiguring(builder);
            builder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=csMovies;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
            builder.LogTo(Console.WriteLine, new[]
            {
                RelationalEventId.CommandExecuted
            });
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Genre>(options =>
            {
                options.HasData(new Genre { Id = 1, Name = "Sci-fi" });
                options.HasData(new Genre { Id = 2, Name = "Horror" });
                options.HasData(new Genre { Id = 3, Name = "Životopis" });
            });
            modelBuilder.Entity<Movie>(options =>
            {
                options.HasData(new Movie { Id = 1, Name = "One Piece", Duration = 24, GenreId = 1 });
                options.HasData(new Movie { Id = 2, Name = "Oppenheimer", Duration = 180, GenreId = 2 });
            });
        }
    }
}

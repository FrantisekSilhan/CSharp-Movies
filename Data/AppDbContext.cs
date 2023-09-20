using _200923PRG.Models;
using Microsoft.EntityFrameworkCore;

namespace _200923PRG.Data
{
    internal class AppDbContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            base.OnConfiguring(builder);
            builder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=csMovies;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Movie>(options =>
            {
                options.HasData(new Movie { Id = 1, Name = "One Piece", Duration = 24 });
                options.HasData(new Movie { Id = 2, Name = "Oppenheimer", Duration = 180 });
            });
        }
    }
}

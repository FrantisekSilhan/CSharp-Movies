using _200923PRG.Models;
using Microsoft.EntityFrameworkCore;

namespace _200923PRG.Data
{
    internal class AppDbContext : DbContext
    {
        private string _connectionString = string.Empty;

        public AppDbContext(string connectionString)
        {
            _connectionString = connectionString;
        }

        public DbSet<Movie> Movies { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            base.OnConfiguring(builder);
            builder.UseSqlServer(_connectionString);
        }
    }
}

using System.ComponentModel.DataAnnotations;

namespace _200923PRG.Models
{
    internal class Genre
    {
        public int GenreId { get; set; }
        [Required]
        public string Name { get; set; } = string.Empty;

        public ICollection<Movie>? Movies { get; set; }
    }
}

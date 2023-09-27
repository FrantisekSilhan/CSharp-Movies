using System.ComponentModel.DataAnnotations;

namespace _200923PRG.Models
{
    internal class Artist
    {
        public int ArtistId { get; set; }
        public string? FirstName { get; set; } = string.Empty;
        [Required]
        public string LastName { get; set; } = string.Empty;
        public Gender Gender { get; set; } = Gender.Unknown;
        public string? WebAddress { get; set; }
        public ICollection<Movie>? Movies { get; set; }
    }
}

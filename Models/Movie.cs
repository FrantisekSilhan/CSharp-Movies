using System.ComponentModel.DataAnnotations;

namespace _200923PRG.Models
{
    internal class Movie
    {
        //public int MovieId { get; set; }

        //[Key]
        //public int KeyToMovie { get; set; }
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;
        public int? Duration { get; set; }

        public Genre Genre { get; set; }
        public int GenreId { get; set; }
    }
}

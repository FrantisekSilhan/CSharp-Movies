using _200923PRG.Data;
using _200923PRG.Models;

var db = new AppDbContext();
// Add-Migration Initial
// Update-Database

IList<Movie> FirstMovies = db.Movies.ToList();
foreach (Movie movie in FirstMovies)
{
    Console.WriteLine(movie.Name);
}
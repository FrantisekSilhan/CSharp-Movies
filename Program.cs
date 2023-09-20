using _200923PRG.Data;
using _200923PRG.Models;
using Microsoft.EntityFrameworkCore;

var db = new AppDbContext();
// Add-Migration Initial
// Update-Database

IList<Movie> movies1 = db.Movies.ToList();
foreach (Movie movie in movies1)
{
    Console.WriteLine(movie.Name);
}

Console.WriteLine();

IList<Movie> movies2 = db.Movies.Where(x => x.Name.Contains("piece")).ToList();
foreach (Movie movie in movies2)
{
    Console.WriteLine(movie.Name);
}

Console.WriteLine();

IList<Movie> movies3 = db.Movies.Include(x => x.Genre).ToList();
foreach (Movie movie in movies3)
{
    Console.WriteLine(string.Format("{0} {1}", movie.Name, movie.Genre!.Name));
}

Console.WriteLine();

Movie? mov = db.Movies.Where(x => x.Id == 1).SingleOrDefault();
if (mov != null)
{
    Console.WriteLine(mov.Name);
}

/*Console.WriteLine("Movie name: ");
string newName = Console.ReadLine();
db.Movies.Add(new Movie { Name = newName, GenreId = 1 });

Console.WriteLine("Saving...");
try
{
    db.SaveChanges();
    Console.WriteLine("Done");
}
catch (Exception ex)
{
    Console.WriteLine(string.Format("Error: {0}", ex));
}*/
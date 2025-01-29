using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace FridayFilmClub.Pages;

public class NameModel : PageModel
{
    private readonly FilmClubContext _context;
    private readonly ILogger<NameModel> _logger;

    public NameModel(FilmClubContext context, ILogger<NameModel> logger)
    {
        _context = context;
        _logger = logger;
    }

    public Celebrities Celebrity { get; set; }
    public List<CelebritiesInMovies> LatestRoles { get; set; }
    public double? AverageRating { get; set; }
    public int NumberOfMovies { get; set; }

    public async Task<IActionResult> OnGetAsync(int id)
    {
        Celebrity = await _context.Celebrities
            .Include(c => c.CelebritiesInMovies)
                .ThenInclude(cim => cim.Movie)
            .Include(c => c.CelebritiesInMovies)
                .ThenInclude(cim => cim.Credit)
            .FirstOrDefaultAsync(c => c.CelebrityID == id);

        if (Celebrity == null)
        {
            return NotFound();
        }

        // Fetch latest roles
        LatestRoles = Celebrity.CelebritiesInMovies
            .OrderByDescending(cim => cim.Movie.ReleaseDate)
            .Take(3)
            .ToList();

        // Calculate average rating
        var movieIds = Celebrity.CelebritiesInMovies.Select(cim => cim.MovieID).Distinct();
        AverageRating = await _context.Reviews
            .Where(r => movieIds.Contains(r.MovieID))
            .AverageAsync(r => (double?)r.Rating);

        // Calculate number of movies
        NumberOfMovies = movieIds.Count();

        return Page();
    }
}
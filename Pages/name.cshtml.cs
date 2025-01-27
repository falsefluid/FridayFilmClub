using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FridayFilmClub.Pages;

public class NameModel : PageModel
{
    private readonly ILogger<NameModel> _logger;

    public NameModel(ILogger<NameModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
    }
}


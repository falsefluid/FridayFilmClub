using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FridayFilmClub.Pages;

public class UserModel : PageModel
{
    private readonly ILogger<UserModel> _logger;

    public UserModel(ILogger<UserModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
    }
}

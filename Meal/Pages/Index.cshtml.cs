using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace XkliburSolutions.Meal.Pages;

/// <summary>
/// Represents the index model for handling the index page.
/// </summary>
/// <param name="logger">The logger instance for logging information.</param>
public class IndexModel(ILogger<IndexModel> logger) : PageModel
{
    private readonly ILogger<IndexModel> _logger = logger;

    /// <summary>
    /// Handles GET requests.
    /// </summary>
    public static void OnGet()
    {

    }
}

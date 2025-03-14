using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;


namespace eshop.Pages;
public class aboutusModel : PageModel
{
    private readonly ILogger<aboutusModel> _logger;

    public aboutusModel(ILogger<aboutusModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {

    }
}
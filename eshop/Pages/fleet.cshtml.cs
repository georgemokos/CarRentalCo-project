using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;


namespace eshop.Pages;
public class fleetModel : PageModel
{
    private readonly ILogger<fleetModel> _logger;

    public fleetModel(ILogger<fleetModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {

    }
}
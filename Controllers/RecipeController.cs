using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using recipe_app.Models;

namespace recipe_app.Controllers;

public class RecipeController : Controller
{
    private readonly ILogger<RecipeController> _logger;

    public RecipeController(ILogger<RecipeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Kwetiauw()
    {
        return View();
    }

    public IActionResult Nasigoreng()
    {
        return View();
    }
      public IActionResult Rendang()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

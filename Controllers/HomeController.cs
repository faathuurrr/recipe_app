using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using recipe_app.Models;

namespace recipe_app.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View(recipes);
    }
    private static List<RecipeModel> recipes = new List<RecipeModel>
    {
        new RecipeModel 
        { 
            Id = 1, 
            Name = "Nasi Goreng", 
            Category = "Indonesia",
            Ingredients = new List<string> { "Rice", "Egg", "Garlic", "Soy Sauce" },
            CookingSteps = new List<string> { "Heat oil in a wok", "Fry garlic until fragrant", "Add rice and stir-fry", "Add soy sauce and mix well" }
        },
        new RecipeModel
        { 
            Id = 2, 
            Name = "Kwetiauw", 
            Category = "Chinese",
            Ingredients = new List<string> { "Flat rice noodles", "Soy Sauce", "Garlic", "Shrimp" },
            CookingSteps = new List<string> { "Soak noodles in hot water", "Stir-fry garlic and shrimp", "Add noodles and soy sauce", "Stir until well mixed" }
        },
        new RecipeModel
        { 
            Id = 3, 
            Name = "Rendang", 
            Category = "Indonesia",
            Ingredients = new List<string> { "Beef", "Coconut Milk", "Chili", "Turmeric leaves" },
            CookingSteps = new List<string> { "Blend spices", "Cook beef in coconut milk", "Simmer for hours until dry", "Serve with rice" }
        }
    };

    public IActionResult RecipeManagement()
    {
        return View(recipes);
    }

    [HttpPost]
    public IActionResult RecipeManagement(string Name, string Category, List<string> Ingredients, List<string> CookingSteps)
    {
        int newId = recipes.Max(r => r.Id) + 1;
        RecipeModel newRecipe = new RecipeModel
        {
            Id = newId,
            Name = Name,
            Category = Category,
            Ingredients = Ingredients,
            CookingSteps = CookingSteps
        };
        recipes.Add(newRecipe);

        return RedirectToAction("RecipeManagement");
    }

    [HttpPost]
    public IActionResult DeleteRecipe(int id)
    {
        var recipe = recipes.FirstOrDefault(r => r.Id == id);
        if (recipe != null)
        {
            recipes.Remove(recipe);
        }
        return RedirectToAction("RecipeManagement");
    }

    public IActionResult About()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

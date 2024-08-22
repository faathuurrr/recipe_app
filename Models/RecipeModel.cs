namespace recipe_app.Models;

public class RecipeModel
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public required string Category { get; set; }
    public List<string> Ingredients { get; set; } = new List<string>();
    public List<string> CookingSteps { get; set; } = new List<string>();
}
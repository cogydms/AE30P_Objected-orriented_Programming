using FridgeBuddyFrontend.Services;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FridgeBuddyFrontend.Pages.Recipes;

public class IndexModel : PageModel
{
    private readonly RecipeService recipeService;

    public IndexModel(RecipeService recipeService)
    {
        this.recipeService = recipeService;
    }

    public string IngredientsInput { get; set; } = "";

    public string RecipeResult { get; set; } = "";

    public async Task OnPostAsync()
    {
        var ingredients = IngredientsInput.Split(',', StringSplitOptions.RemoveEmptyEntries)
                                         .Select(i => i.Trim())
                                         .ToList();
        RecipeResult = await recipeService.GetRecipesAsync(ingredients);
    }
}

using FridgeBuddyFrontend.Models;
using FridgeBuddyFrontend.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FridgeBuddyFrontend.Pages.FridgeBuddy;

public class IndexModel : PageModel
{
    private readonly IngredientService service;

    public IndexModel(IngredientService s)
    {
        service = s;
        IngredientsByCategory = new Dictionary<string, List<Ingredient>>();
    }

    public Dictionary<string, List<Ingredient>> IngredientsByCategory { get; set; }

    [BindProperty(SupportsGet = true)]
    public string? Search { get; set; }

    public async Task OnGetAsync()
    {
        var allIngredients = await service.GetAllAsync();

        if (!string.IsNullOrWhiteSpace(Search))
        {
            allIngredients = allIngredients
                .Where(i => i.Name.Contains(Search, StringComparison.OrdinalIgnoreCase))
                .ToList();
        }

        IngredientsByCategory = allIngredients
            .OrderBy(i => i.ExpirationDate)
            .GroupBy(i => i.Category ?? "Uncategorized")
            .ToDictionary(g => g.Key, g => g.ToList());
    }


    public string GetCategoryEmoji(string category)
    {
        return category.ToLower() switch
        {
            "fruit" => "🍎",
            "seafood" => "🐟",
            "vegetable" => "🥦",
            "dairy" => "🧀",
            "meat" => "🥩",
            "etc" => "🛒",
            _ => "🛒"
        };
    }
}

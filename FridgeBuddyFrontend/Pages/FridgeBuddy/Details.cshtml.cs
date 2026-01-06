using FridgeBuddyFrontend.Models;
using FridgeBuddyFrontend.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FridgeBuddyFrontend.Pages.FridgeBuddy;

public class DetailsModel : PageModel
{
    private readonly IngredientService service;
        
    public DetailsModel(IngredientService service)
    {
        this.service = service;
    }

    public Ingredient item { get; set; } = new Ingredient();

    public async Task<IActionResult> OnGetAsync(int id)
    {
        var ingredient = await service.GetByIdAsync(id);

        if (ingredient == null)
            return NotFound();

        item = ingredient;

        return Page();
    }
}
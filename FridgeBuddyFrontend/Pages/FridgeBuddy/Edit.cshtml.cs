using FridgeBuddyFrontend.Models;
using FridgeBuddyFrontend.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FridgeBuddyFrontend.Pages.FridgeBuddy;

public class EditModel : PageModel
{
    private readonly IngredientService service;
    public EditModel(IngredientService service)
        {
            this.service = service;
        }

    [BindProperty]
    public Ingredient item { get; set; } = new Ingredient();

    public async Task<IActionResult> OnGetAsync(int id)
    {
        var ingredient = await service.GetByIdAsync(id);

        if (ingredient == null)
            return NotFound();
            
        item = ingredient;
        
        return Page();
    }

    public async Task<IActionResult> OnPostAsync()
    {   
        if (!ModelState.IsValid)
            return Page();
        
        var success = await service.UpdateAsync(item.ID, item);
        if (success)
            return RedirectToPage("./Index");

        ModelState.AddModelError(string.Empty, "Error editing ingredient. Please try again.");
        return Page();
    }
}
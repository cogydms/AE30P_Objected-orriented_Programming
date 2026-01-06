using FridgeBuddyFrontend.Models;
using FridgeBuddyFrontend.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FridgeBuddyFrontend.Pages.FridgeBuddy;

    public class CreateModel : PageModel
    {
        private readonly IngredientService service;
        
        public CreateModel(IngredientService service)
        {
            this.service = service;
        }

        [BindProperty]
        public Ingredient item { get; set; } = new Ingredient();

        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            var success = await service.CreateAsync(item);

            if (success)
            {
                return RedirectToPage("./Index");
            }

            ModelState.AddModelError(string.Empty, "Error creating Ingredient. Please try again.");
            return Page();
        }
    }

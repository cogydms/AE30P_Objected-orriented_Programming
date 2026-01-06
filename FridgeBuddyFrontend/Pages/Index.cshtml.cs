using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using FridgeBuddyFrontend.Models;
using FridgeBuddyFrontend.Services;

namespace FridgeBuddyFrontend.Pages;
public class IndexModel : PageModel
{
    private readonly IngredientService service;

    public IndexModel(IngredientService s)
    {
        service = s;
    }

    public int TotalCount { get; set; }
    public int ExpiringSoonCount { get; set; }
    public int ExpiredCount { get; set; }

    public async Task OnGetAsync()
    {
        var ingredients = await service.GetAllAsync();
        var today = DateTime.Today;

        TotalCount = ingredients.Count;

        ExpiringSoonCount = ingredients.Count(i =>
            i.ExpirationDate >= today &&
            (i.ExpirationDate - today).TotalDays <= 3
        );

        ExpiredCount = ingredients.Count(i =>
            i.ExpirationDate < today
        );
    }
}

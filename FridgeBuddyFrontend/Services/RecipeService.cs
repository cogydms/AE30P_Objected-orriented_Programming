using System.Net.Http.Json;

namespace FridgeBuddyFrontend.Services;

public class RecipeService
{
    private readonly HttpClient client;
    private readonly IConfiguration config;
    private readonly string baseBackendUrl;

    public RecipeService(HttpClient client, IConfiguration config)
    {
        this.client = client;
        this.config = config;
        baseBackendUrl = config["AppSettings:BaseEndpointUrl"];
    }

    public async Task<string> GetRecipesAsync(List<string> ingredients)
    {
        var response = await client.PostAsJsonAsync($"{baseBackendUrl}/api/recipes/recommend", ingredients);
        if (response.IsSuccessStatusCode)
        {
            var json = await response.Content.ReadFromJsonAsync<RecipeResponse>();
            return json?.Recipes ?? "No recipes found.";
        }
        return "Error calling AI service.";
    }
}

public class RecipeResponse
{
    public string Recipes { get; set; } = string.Empty;
}

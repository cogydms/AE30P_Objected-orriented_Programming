using FridgeBuddyFrontend.Models;
using System.Text.Json;

namespace FridgeBuddyFrontend.Services;

public class IngredientService
{
    private readonly HttpClient client;
    private readonly IConfiguration config;
    private readonly string baseBackendUrl;
    private readonly JsonSerializerOptions options;

    public IngredientService(HttpClient c, IConfiguration ic)
    {
        client = c;
        config = ic;

        baseBackendUrl = config["AppSettings:BaseEndpointUrl"];

        options = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        };
    }

    public async Task<List<Ingredient>> GetAllAsync()
    {
        string fullurl = $"{baseBackendUrl}/api/fridge";
        var response = await client.GetAsync(fullurl);

        if (response.IsSuccessStatusCode)
        {
            var content = await response.Content.ReadAsStringAsync();
            var list = JsonSerializer.Deserialize<List<Ingredient>>(content, options);
            return list ?? new List<Ingredient>();
        }
        else 
        {
            return new List<Ingredient>();
        }
    }

    public async Task<Ingredient?> GetByIdAsync(int id)
    {
        var response = await client.GetAsync($"{baseBackendUrl}/api/fridge/{id}");
        response.EnsureSuccessStatusCode();
        
        if (response.IsSuccessStatusCode)
        {
            var content = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<Ingredient>(content, options);
        }
        else
            return null;
    }

    public async Task<bool> CreateAsync(Ingredient s)
    {
        var json = JsonSerializer.Serialize(s);
        var content = new StringContent(json, System.Text.Encoding.UTF8, "application/json");
        
        var response = await client.PostAsync($"{baseBackendUrl}/api/fridge", content);
        return response.IsSuccessStatusCode;
    }

    public async Task<bool> UpdateAsync(int id, Ingredient s)
    {
        var json = JsonSerializer.Serialize(s);
        var content = new StringContent(json, System.Text.Encoding.UTF8, "application/json");
        
        var response = await client.PutAsync($"{baseBackendUrl}/api/fridge/{id}", content);
        return response.IsSuccessStatusCode;
    }

    public async Task<bool> DeleteAsync(int id)
    {
        var response = await client.DeleteAsync($"{baseBackendUrl}/api/fridge/{id}");
        return response.IsSuccessStatusCode;
    }
}

using Microsoft.AspNetCore.Mvc;
using FridgeBuddyApi.Models;
using FridgeBuddyApi.Services;
using System.Net.Http.Json;

namespace FridgeBuddyApi.Endpoints;

public static class FridgeBuddyEndpoint
{
    static string endpoint = "/api/fridge";

    public static void MapFridgeEndpoints(this WebApplication app)
    {
        app.MapGet(endpoint, async (IDbService dbs) =>
            await dbs.GetAll());

        app.MapGet(endpoint + "/{id}", async (IDbService dbs, int id) =>
        {
            var item = await dbs.Get(id);
            return item is not null ? Results.Ok(item) : Results.NotFound();
        });

        app.MapPost(endpoint, async (IDbService dbs, [FromBody] FridgeBuddy item) =>
        {
            await dbs.Add(item);
            return Results.Created($"{endpoint}/{item.ID}", item);
        });

        app.MapPut(endpoint + "/{id}", async (IDbService dbs, int id, [FromBody] FridgeBuddy item) =>
        {
            await dbs.Update(id, item);
            return Results.NoContent();
        });

        app.MapDelete(endpoint + "/{id}", async (IDbService dbs, int id) =>
        {
            await dbs.Delete(id);
            return Results.NoContent();
        });
    }
}
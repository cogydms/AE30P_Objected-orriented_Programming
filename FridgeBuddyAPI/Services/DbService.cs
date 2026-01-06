using Microsoft.EntityFrameworkCore; 
using FridgeBuddyApi.Models;
using FridgeBuddyApi.Context;

namespace FridgeBuddyApi.Services;

public class DbService : IDbService
{
    FridgeBuddyDbContext db;

    public DbService(FridgeBuddyDbContext db)
    {
        this.db = db;
    }
    
    public async Task<List<FridgeBuddy>> GetAll(){
        return await db.Ingredients.ToListAsync();
    }

    public async Task<FridgeBuddy> Get(int id){
        return await db.Ingredients.FindAsync(id);
    }

    public async Task Add(FridgeBuddy n){
        await db.AddAsync(n);
        await db.SaveChangesAsync();
    } 


    public async Task Update(int id, FridgeBuddy item)
    {
        var fridgeItem  = await db.Ingredients.FindAsync(id);

        if (fridgeItem  != null)
        {
            fridgeItem.Name = item.Name;
            fridgeItem.Quantity = item.Quantity;
            fridgeItem.StorageType = item.StorageType;
            fridgeItem.Category = item.Category;
            fridgeItem.PurchaseDate = item.PurchaseDate;
            fridgeItem.ExpirationDate = item.ExpirationDate;

            await db.SaveChangesAsync();
        }
    }

    public async Task Delete(int id)
    {
        var fridgeItem = await db.Ingredients.FindAsync(id);

        if (fridgeItem != null)
        {
            db.Ingredients.Remove(fridgeItem);
            await db.SaveChangesAsync();
        }
    }
}
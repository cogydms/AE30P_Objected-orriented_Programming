using FridgeBuddyApi.Models;
namespace FridgeBuddyApi.Services;

public interface IDbService
{
    Task<List<FridgeBuddy>> GetAll();
    Task<FridgeBuddy> Get(int id);
    Task Add(FridgeBuddy item);

    Task Update(int id, FridgeBuddy item);
    Task Delete(int id);
}
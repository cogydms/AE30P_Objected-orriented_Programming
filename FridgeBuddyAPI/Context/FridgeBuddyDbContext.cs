using Microsoft.EntityFrameworkCore;
using FridgeBuddyApi.Models;

namespace FridgeBuddyApi.Context;

public class FridgeBuddyDbContext : DbContext
{
    public DbSet<FridgeBuddy> Ingredients {get; set;}
    public FridgeBuddyDbContext(DbContextOptions<FridgeBuddyDbContext> options) : base(options)
    {
        
    }
}
using System.ComponentModel.DataAnnotations.Schema;

namespace FridgeBuddyApi.Models;

[Table("Ingredients")]
public class FridgeBuddy : BaseTable
{
    public string Name { get; set; } = string.Empty;
    public int Quantity { get; set; }
    public string StorageType { get; set; } = string.Empty;
    public string Category { get; set; } = string.Empty;
    public DateTime PurchaseDate { get; set; }
    public DateTime ExpirationDate { get; set; }
}

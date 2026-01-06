namespace FridgeBuddyFrontend.Models;

using System.ComponentModel.DataAnnotations;

public class Ingredient
{
    public int ID { get; set; }

    [Required(ErrorMessage = "Name is required")]
    [StringLength(100, ErrorMessage = "Name cannot exceed 100 characters")]
    public string Name { get; set; } = string.Empty;

    [Required(ErrorMessage = "Quantity is required")]
    public int Quantity { get; set; } = 1;

    [Required(ErrorMessage = "StorageType is required")]
    public string StorageType { get; set; } = string.Empty;
    public string Category { get; set; } = string.Empty;

    [DataType(DataType.Date)]
    public DateTime PurchaseDate { get; set; } = DateTime.Now;
    [DataType(DataType.Date)]
    public DateTime ExpirationDate { get; set; } = DateTime.Now;

}
namespace StockFlow.Api.Models;

public class Category
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;

    // A category can have many products
    public ICollection<Product> Products { get; set; } = new List<Product>();
}

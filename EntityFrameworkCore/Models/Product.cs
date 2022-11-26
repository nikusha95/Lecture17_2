namespace EntityFrameworkCore.Models;

public class Product
{
    public int Id { get; set; }
    public int TypeId { get; set; }
    public decimal Price { get; set; }
    public int Amount { get; set; }
    public ProductType ProductType { get; set; }
    public List<ProductOrder> ProductOrders { get; set; }
}
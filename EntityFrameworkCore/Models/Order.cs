namespace EntityFrameworkCore.Models;

public class Order
{
    public int Id { get; set; }
    public int StatusId { get; set; }
    public DateTime CreateDate { get; set; }
    public Status Status { get; set; }
    public int CustomerId { get; set; }
    public Customer Customer { get; set; }
    public List<ProductOrder> ProductOrders { get; set; }
}
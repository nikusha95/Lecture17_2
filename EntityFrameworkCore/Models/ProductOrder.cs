using System.Data.Common;

namespace EntityFrameworkCore.Models;

public class ProductOrder
{
    public int Id { get; set; }
    public int ProductId { get; set; }
    public int OrderId { get; set; }
    public int Amount { get; set; }
    public Product Product { get; set; }
    public Order Order { get; set; }
}
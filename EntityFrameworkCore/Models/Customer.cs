namespace EntityFrameworkCore.Models;

public class Customer
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string PersonalId { get; set; }
    public string ZipCode { get; set; }
    public string ShippingAddress { get; set; }
    public List<Account> Accounts { get; set; }
    public List<Order> Orders { get; set; }
}
using System.ComponentModel.DataAnnotations;

namespace EntityFrameworkCore.Models;

public class Account
{
    public int Id { get; set; }
    public string Iban { get; set; }
    public decimal Balance { get; set; }
    public int CustomerId { get; set; }
    public Customer Customer { get; set; }
}
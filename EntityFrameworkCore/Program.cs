// See https://aka.ms/new-console-template for more information

using System.Threading.Channels;
using EntityFrameworkCore;
using EntityFrameworkCore.Models;
using Microsoft.EntityFrameworkCore;

ShopDbContext dbContext = new ShopDbContext();

// await dbContext.ProductTypes.AddAsync(new ProductType
// {
//     Name = "Drink"
// });

//await dbContext.SaveChangesAsync();


//add status

// var status =  dbContext.Statuses.FirstOrDefault(x => x.Id == 1);
//
// status.Name = "InProgress";
//
// dbContext.Statuses.Update(status);
//
// await dbContext.SaveChangesAsync();//needed when  require to update or add


// await dbContext.Orders.AddAsync(new Order
// {
//     CustomerId = 1,
//     StatusId = 1
// });
//
// await dbContext.SaveChangesAsync();


var order = await dbContext.Orders
    .Include(x=>x.Customer)
    .Include(x=>x.Status)
    .FirstOrDefaultAsync(x => x.Id == 1);

Console.WriteLine($"order status {order.Status.Name}");



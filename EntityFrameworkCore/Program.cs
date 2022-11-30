// See https://aka.ms/new-console-template for more information

using EntityFrameworkCore;
using EntityFrameworkCore.Models;

ShopDbContext dbContext = new ShopDbContext();

// await dbContext.ProductTypes.AddAsync(new ProductType
// {
//     Name = "Drink"
// });

//await dbContext.SaveChangesAsync();


//add status

var status =  dbContext.Statuses.FirstOrDefault(x => x.Id == 1);

status.Name = "InProgress";

dbContext.Statuses.Update(status);

await dbContext.SaveChangesAsync();//needed when  require to update or add





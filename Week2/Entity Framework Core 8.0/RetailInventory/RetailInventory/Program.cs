using Microsoft.EntityFrameworkCore;
using RetailInventory;

using var context = new AppDbContext();

var products = await context.Products
    .Include(p => p.Category)
    .ToListAsync();

foreach (var product in products)
{
    Console.WriteLine(
        $"{product.Name} - ₹{product.Price} - Category: {product.Category.Name}"
    );
}
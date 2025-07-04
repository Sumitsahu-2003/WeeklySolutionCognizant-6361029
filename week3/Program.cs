using System;
using System.Threading.Tasks;
using RetailInventory;
using Microsoft.EntityFrameworkCore;

class Program
{
    static async Task Main(string[] args)
    {
        using var context = new AppDbContext();

        // Insert initial data if database is empty (optional check)
        if (!await context.Categories.AnyAsync())
        {
            var electronics = new Category { Name = "Electronics" };
            var groceries = new Category { Name = "Groceries" };

            await context.Categories.AddRangeAsync(electronics, groceries);

            var product1 = new Product { Name = "Laptop", Price = 75000, Category = electronics };
            var product2 = new Product { Name = "Rice Bag", Price = 1200, Category = groceries };

            await context.Products.AddRangeAsync(product1, product2);
            await context.SaveChangesAsync();

            Console.WriteLine("Data inserted successfully.\n");
        }
        else
        {
            Console.WriteLine("Data already exists.\n");
        }

        // Lab 5: Retrieving Data

        // 1. Retrieve all products
        var products = await context.Products.ToListAsync();
        Console.WriteLine("All Products:");
        foreach (var p in products)
        {
            Console.WriteLine($"{p.Name} - ₹{p.Price}");
        }
        Console.WriteLine();

        // 2. Find product by ID
        var product = await context.Products.FindAsync(1);
        Console.WriteLine($"Found by ID (1): {product?.Name ?? "Not found"}");
        Console.WriteLine();

        // 3. FirstOrDefault with condition (price > 50000)
        var expensive = await context.Products.FirstOrDefaultAsync(p => p.Price > 50000);
        Console.WriteLine($"Expensive Product: {expensive?.Name ?? "None found"}");
    }
}

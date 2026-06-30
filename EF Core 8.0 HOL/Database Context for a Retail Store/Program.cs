using System;
using Microsoft.EntityFrameworkCore;
using RetailInventory.Data;
using RetailInventory.Models;

namespace RetailInventory
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            using var context = new AppDbContext();

            Console.WriteLine("All Products");
            var products = await context.Products.ToListAsync();

            foreach (var p in products)
            {
                Console.WriteLine($"{p.Name} - ₹{p.Price}");
            }

            Console.WriteLine();

            var product = await context.Products.FindAsync(1);

            Console.WriteLine("Find by ID");
            Console.WriteLine($"Found: {product?.Name}");

            Console.WriteLine();
            var expensive = await context.Products
                                         .FirstOrDefaultAsync(p => p.Price > 50000);

            Console.WriteLine("First Expensive Product");
            Console.WriteLine($"Expensive: {expensive?.Name}");

            Console.ReadKey();
        }
    }
}

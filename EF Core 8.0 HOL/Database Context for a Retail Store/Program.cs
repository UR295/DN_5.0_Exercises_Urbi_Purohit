using System;
using RetailInventory.Data;

namespace RetailInventory
{
    class Program
    {
        static void Main(string[] args)
        {
            using (AppDbContext db = new AppDbContext())
            {
                Console.WriteLine("Database Context Created Successfully.");
            }

            Console.ReadKey();
        }
    }
}

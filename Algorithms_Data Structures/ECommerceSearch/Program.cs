using System;

namespace ECommerceSearchExample
{
    class Program
    {
        static Product LinearSearch(Product[] products, int id)
        {
            foreach (Product product in products)
            {
                if (product.ProductId == id)
                {
                    return product;
                }
            }

            return null;
        }
      
        static Product BinarySearch(Product[] products, int id)
        {
            int left = 0;
            int right = products.Length - 1;

            while (left <= right)
            {
                int mid = (left + right) / 2;

                if (products[mid].ProductId == id)
                {
                    return products[mid];
                }
                else if (products[mid].ProductId < id)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }

            return null;
        }

        static void Main(string[] args)
        {
            Product[] products =
            {
                new Product(101,"Laptop","Electronics"),
                new Product(102,"Mobile","Electronics"),
                new Product(103,"Shoes","Fashion"),
                new Product(104,"Watch","Accessories"),
                new Product(105,"Book","Education")
            };

            Console.WriteLine("Linear Search");
            Product p1 = LinearSearch(products, 104);

            if (p1 != null)
                p1.Display();
            else
                Console.WriteLine("Product Not Found");

            Console.WriteLine();

            Console.WriteLine("Binary Search");
            Product p2 = BinarySearch(products, 104);

            if (p2 != null)
                p2.Display();
            else
                Console.WriteLine("Product Not Found");

            Console.ReadKey();
        }
    }
}

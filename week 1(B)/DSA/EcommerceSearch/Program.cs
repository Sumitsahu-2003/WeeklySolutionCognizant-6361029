using System;
using System.Linq;

namespace EcommerceSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            Product[] products = new Product[]
            {
                new Product(1, "Laptop", "Electronics"),
                new Product(2, "Mouse", "Electronics"),
                new Product(3, "Shoes", "Footwear"),
                new Product(4, "Shirt", "Clothing"),
                new Product(5, "Phone", "Electronics")
            };

            string searchTerm = "Shoes";

            Console.WriteLine("🔍 Linear Search:");
            var resultLinear = SearchAlgorithms.LinearSearch(products, searchTerm);
            Console.WriteLine(resultLinear != null ? $"Found: {resultLinear.ProductName}" : "Not found");

            Console.WriteLine("\n🔍 Binary Search:");
            var sortedProducts = products.OrderBy(p => p.ProductName).ToArray();
            var resultBinary = SearchAlgorithms.BinarySearch(sortedProducts, searchTerm);
            Console.WriteLine(resultBinary != null ? $"Found: {resultBinary.ProductName}" : "Not found");
        }
    }
}

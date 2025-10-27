using System;
using System.Collections.Generic;
using CoreLibrary;
using UtilityLibrary;

namespace DemoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== C# Features Demonstration ===\n");

            // 1. Custom Interface
            Console.WriteLine("1. Custom Interface Implementation:");
            Product product1 = new Product("Laptop", 999.99m, 10, "Electronics");
            ICustomInterface customInterface = product1;
            Console.WriteLine(customInterface.GetDescription());
            customInterface.Process();

            // 2. IComparable<T>
            Console.WriteLine("\n2. IComparable<T> Implementation:");
            var product2 = new Product("Mouse", 25.50m, 50);
            var product3 = new Product("Keyboard", 75.00m, 30);
            var products = new List<Product> { product2, product3, product1 };
            products.Sort();
            Console.WriteLine("Sorted by price:");
            products.ForEach(p => Console.WriteLine($"  {p}"));

            // 3. IEquatable<T>
            Console.WriteLine("\n3. IEquatable<T> Implementation:");
            var product4 = new Product("Mouse", 25.50m, 100);
            Console.WriteLine($"product2 equals product4: {product2.Equals(product4)}");

            // 4. IFormattable
            Console.WriteLine("\n4. IFormattable Implementation:");
            Console.WriteLine($"General format: {product1.ToString("G", null)}");
            Console.WriteLine($"Detailed format: {product1.ToString("D", null)}");
            Console.WriteLine($"Stock format: {product1.ToString("S", null)}");

            // 5. Switch with when keyword (in Product.ToString)
            Console.WriteLine("\n5. Switch with 'when' keyword (demonstrated in formatting above)");

            // 6. Range type
            Console.WriteLine("\n6. Range Type:");
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var range = DataProcessor.GetRange(numbers, 2..5);
            Console.WriteLine($"Elements [2..5]: {string.Join(", ", range)}");

            // 7. Multiple assemblies
            Console.WriteLine("\n7. Multiple Assemblies:");
            Console.WriteLine($"CoreLibrary and UtilityLibrary are separate assemblies");

            // 8. Sealed and Partial classes
            Console.WriteLine("\n8. Sealed class (Product) and Partial class (Customer):");
            var customer = new Customer("John Doe", "john@example.com");
            Console.WriteLine(customer.GetInfo());

            // 9. Abstract class
            Console.WriteLine("\n9. Abstract Class (BaseEntity):");
            customer.Save();

            // 10. Static constructor
            Console.WriteLine("\n10. Static Constructor:");
            Console.WriteLine($"Default category: {Product.DefaultCategory}");

            // 11. Deconstructor
            Console.WriteLine("\n11. Deconstructor:");
            var (name, price, stock) = product1;
            Console.WriteLine($"Deconstructed: Name={name}, Price={price}, Stock={stock}");

            // 12. Operator overloading
            Console.WriteLine("\n12. Operator Overloading:");
            var combined = product2 + product3;
            Console.WriteLine($"Combined product: {combined}");
            Console.WriteLine($"product2 == product4: {product2 == product4}");

            // 13. System.Collections.Generic
            Console.WriteLine("\n13. System.Collections.Generic:");
            var wordCount = DataProcessor.CreateWordCount("apple", "banana", "apple", "cherry", "banana", "apple");
            foreach (var kvp in wordCount)
            {
                Console.WriteLine($"  {kvp.Key}: {kvp.Value}");
            }

            // 14. is operator
            Console.WriteLine("\n14. 'is' Operator:");
            object obj = product1;
            Console.WriteLine($"obj is Product: {DataProcessor.IsValidProduct(obj)}");
            Console.WriteLine($"Type check: {DataProcessor.CheckType("Hello")}");

            // 15. Default and named arguments
            Console.WriteLine("\n15. Default and Named Arguments:");
            var product5 = new Product("Monitor", 299.99m); // Using default stock=0
            Console.WriteLine($"Product with default stock: {product5}");
            customer.UpdateContact(email: "newemail@example.com"); // Named argument

            // 16. params keyword
            Console.WriteLine("\n16. 'params' Keyword:");
            int sum = DataProcessor.Sum(1, 2, 3, 4, 5);
            Console.WriteLine($"Sum of 1,2,3,4,5: {sum}");

            // 17. out arguments
            Console.WriteLine("\n17. 'out' Arguments:");
            if (DataProcessor.TryParseRange("10-20", out int start, out int end))
            {
                Console.WriteLine($"Parsed range: {start} to {end}");
            }

            // 18. Delegates and lambda functions
            Console.WriteLine("\n18. Delegates and Lambda Functions:");
            var numbersList = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var evenNumbers = DataProcessor.FilterList(numbersList, n => n % 2 == 0);
            Console.WriteLine($"Even numbers: {string.Join(", ", evenNumbers)}");

            // 19. Bitwise operations
            Console.WriteLine("\n19. Bitwise Operations:");
            int flags = 0;
            flags = DataProcessor.SetFlag(flags, 1); // Set bit 0
            flags = DataProcessor.SetFlag(flags, 4); // Set bit 2
            Console.WriteLine($"Flags after setting: {Convert.ToString(flags, 2).PadLeft(8, '0')}");
            Console.WriteLine($"Has flag 4: {DataProcessor.HasFlag(flags, 4)}");
            flags = DataProcessor.ToggleFlag(flags, 1);
            Console.WriteLine($"Flags after toggle: {Convert.ToString(flags, 2).PadLeft(8, '0')}");

            // 20. Null-coalescing operators
            Console.WriteLine("\n20. Null-Coalescing Operators (?., ?[], ??, ??=):");
            string? nullName = null;
            Console.WriteLine($"Safe name: {DataProcessor.GetSafeName(nullName, "Smith")}");
            int[]? nullArray = null;
            Console.WriteLine($"First element of null array: {DataProcessor.GetFirstElement(nullArray)?.ToString() ?? "null"}");

            // 21. Pattern matching
            Console.WriteLine("\n21. Pattern Matching:");
            Console.WriteLine(DataProcessor.DescribeObject(42));
            Console.WriteLine(DataProcessor.DescribeObject(-5));
            Console.WriteLine(DataProcessor.DescribeObject("Hello"));
            Console.WriteLine(DataProcessor.DescribeObject(product1));
            Console.WriteLine(DataProcessor.DescribeObject(new List<int> { 1, 2, 3 }));

            Console.WriteLine("\n=== All Requirements Demonstrated Successfully! ===");
        }
    }
}

using System;
using System.Collections.Generic;

namespace CoreLibrary
{
    // Sealed class (Requirement 8)
    // Implements IComparable<T> (Requirement 2), IEquatable<T> (Requirement 3), 
    // IFormattable (Requirement 4), and custom interface (Requirement 1)
    public sealed class Product : IComparable<Product>, IEquatable<Product>, IFormattable, ICustomInterface
    {
        // Static constructor (Requirement 10)
        static Product()
        {
            DefaultCategory = "Uncategorized";
        }

        public static string DefaultCategory { get; private set; }

        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public string Category { get; set; }
        private int _internalId;

        // Constructor with default arguments (Requirement 15)
        public Product(string name, decimal price, int stock = 0, string? category = null)
        {
            Name = name;
            Price = price;
            Stock = stock;
            Category = category ?? DefaultCategory;
            _internalId = GetHashCode();
        }

        // Deconstructor (Requirement 11)
        public void Deconstruct(out string name, out decimal price, out int stock)
        {
            name = Name;
            price = Price;
            stock = Stock;
        }

        // IComparable<T> implementation (Requirement 2)
        public int CompareTo(Product? other)
        {
            if (other == null) return 1;
            return Price.CompareTo(other.Price);
        }

        // IEquatable<T> implementation (Requirement 3)
        public bool Equals(Product? other)
        {
            if (other == null) return false;
            return Name == other.Name && Price == other.Price;
        }

        // IFormattable implementation (Requirement 4)
        public string ToString(string? format, IFormatProvider? formatProvider)
        {
            if (string.IsNullOrEmpty(format)) format = "G";
            formatProvider ??= System.Globalization.CultureInfo.CurrentCulture;

            // Switch with when keyword (Requirement 5)
            return format.ToUpperInvariant() switch
            {
                "G" => $"{Name}: {Price:C}",
                "D" when Stock > 0 => $"{Name} - Price: {Price:C}, Stock: {Stock}, Category: {Category}",
                "D" => $"{Name} - Price: {Price:C}, Out of Stock, Category: {Category}",
                "S" => $"{Name} ({Stock} in stock)",
                _ => ToString()
            };
        }

        // Custom interface implementation (Requirement 1)
        public string GetDescription()
        {
            return $"Product: {Name}, Category: {Category}";
        }

        public void Process()
        {
            Console.WriteLine($"Processing product: {Name}");
        }

        // Operator overloading (Requirement 12)
        public static Product operator +(Product a, Product b)
        {
            return new Product(
                $"{a.Name} & {b.Name}",
                a.Price + b.Price,
                a.Stock + b.Stock,
                a.Category
            );
        }

        public static bool operator ==(Product? a, Product? b)
        {
            if (ReferenceEquals(a, b)) return true;
            if (a is null || b is null) return false;
            return a.Equals(b);
        }

        public static bool operator !=(Product? a, Product? b)
        {
            return !(a == b);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as Product);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Name, Price);
        }

        public override string ToString()
        {
            return $"{Name}: {Price:C}";
        }
    }
}

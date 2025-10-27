using System;

namespace CoreLibrary
{
    // Partial class (Requirement 8)
    public partial class Customer : BaseEntity
    {
        public string Name { get; set; }
        public string Email { get; set; }

        public Customer(string name, string email)
        {
            Name = name;
            Email = email;
            Id = new Random().Next(1000, 9999);
        }

        // Override abstract method
        public override void Save()
        {
            Console.WriteLine($"Saving customer: {Name}");
        }
    }

    // Second part of partial class (Requirement 8)
    public partial class Customer
    {
        // Named arguments will be used when calling this (Requirement 15)
        public void UpdateContact(string? email = null, string? phone = null, string? address = null)
        {
            if (email != null) Email = email;
            Console.WriteLine($"Contact updated for {Name}");
        }

        public override string GetInfo()
        {
            return $"Customer: {Name}, Email: {Email}, {base.GetInfo()}";
        }
    }
}

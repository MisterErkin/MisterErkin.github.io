using System;
using System.Collections.Generic;
using System.Linq;
using CoreLibrary;

namespace UtilityLibrary
{
    public static class DataProcessor
    {
        // Delegates (Requirement 18)
        public delegate bool FilterDelegate(int value);
        public delegate string TransformDelegate(string input);

        // Method using params keyword (Requirement 16)
        public static int Sum(params int[] numbers)
        {
            return numbers.Sum();
        }

        // Method using out arguments (Requirement 17)
        public static bool TryParseRange(string input, out int start, out int end)
        {
            start = 0;
            end = 0;

            if (string.IsNullOrWhiteSpace(input))
                return false;

            var parts = input.Split('-');
            if (parts.Length != 2)
                return false;

            return int.TryParse(parts[0], out start) && int.TryParse(parts[1], out end);
        }

        // Method using Range type (Requirement 6)
        public static T[] GetRange<T>(T[] array, Range range)
        {
            return array[range];
        }

        // Method using lambda functions (Requirement 18)
        public static List<T> FilterList<T>(List<T> items, Func<T, bool> predicate)
        {
            return items.Where(predicate).ToList();
        }

        // Method using bitwise operations (Requirement 19)
        public static int SetFlag(int value, int flag)
        {
            return value | flag;
        }

        public static int ClearFlag(int value, int flag)
        {
            return value & ~flag;
        }

        public static bool HasFlag(int value, int flag)
        {
            return (value & flag) == flag;
        }

        public static int ToggleFlag(int value, int flag)
        {
            return value ^ flag;
        }

        // Method using null-coalescing operators (Requirement 20)
        public static string GetSafeName(string? firstName, string? lastName, string? defaultName = "Unknown")
        {
            // Using ?? operator
            string name = firstName ?? lastName ?? defaultName ?? "N/A";
            
            // Using ?. operator - check length safely
            int? length = firstName?.Length;
            string nameInfo = length.HasValue ? $"{name} (length: {length})" : name;
            
            return nameInfo;
        }

        // Method using pattern matching (Requirement 21)
        public static string DescribeObject(object obj)
        {
            // Pattern matching with type patterns
            return obj switch
            {
                null => "Null object",
                int i when i > 0 => $"Positive integer: {i}",
                int i when i < 0 => $"Negative integer: {i}",
                int => "Zero",
                string s when !string.IsNullOrEmpty(s) => $"String with length {s.Length}: {s}",
                string => "Empty or null string",
                CoreLibrary.Product p => $"Product: {p.ToString()}",
                IList<int> list => $"Integer list with {list.Count} items",
                _ => $"Unknown type: {obj.GetType().Name}"
            };
        }

        // Method using is operator (Requirement 14)
        public static bool IsValidProduct(object obj)
        {
            // Using is operator
            if (obj is CoreLibrary.Product product)
            {
                return product.Price > 0;
            }
            return false;
        }

        // Method using is operator with pattern
        public static string CheckType(object obj)
        {
            if (obj is string text)
                return $"String: {text}";
            if (obj is int number)
                return $"Integer: {number}";
            if (obj is null)
                return "Null";
            
            return "Unknown";
        }

        // Using System.Collections.Generic (Requirement 13)
        public static Dictionary<string, int> CreateWordCount(params string[] words)
        {
            var wordCount = new Dictionary<string, int>();
            
            foreach (var word in words)
            {
                // Using ??= operator (Requirement 20)
                wordCount.TryGetValue(word, out int count);
                wordCount[word] = count + 1;
            }
            
            return wordCount;
        }

        // Method demonstrating ?[] operator
        public static int? GetFirstElement(int[]? array)
        {
            // Using ?[] operator (Requirement 20)
            return array?[0];
        }
    }
}

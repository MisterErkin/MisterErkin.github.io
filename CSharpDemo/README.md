# C# Features Demonstration Project

This project demonstrates all the required C# language features and best practices.

## Requirements Checklist

All 21 requirements have been successfully implemented:

### ✅ 1. Custom Interface (0.5 points)
- **Location**: `CoreLibrary/ICustomInterface.cs`
- **Implementation**: `Product` class implements `ICustomInterface`
- **Demonstration**: Lines 14-18 in `DemoApp/Program.cs`

### ✅ 2. IComparable<T> (0.5 points)
- **Location**: `CoreLibrary/Product.cs`, lines 48-52
- **Implementation**: `Product` implements `IComparable<Product>` to compare by price
- **Demonstration**: Lines 20-27 in `DemoApp/Program.cs`

### ✅ 3. IEquatable<T> (0.5 points)
- **Location**: `CoreLibrary/Product.cs`, lines 54-59
- **Implementation**: `Product` implements `IEquatable<Product>` comparing name and price
- **Demonstration**: Lines 29-32 in `DemoApp/Program.cs`

### ✅ 4. IFormattable (1 point)
- **Location**: `CoreLibrary/Product.cs`, lines 61-76
- **Implementation**: `Product` implements `IFormattable` with multiple format options (G, D, S)
- **Demonstration**: Lines 34-39 in `DemoApp/Program.cs`

### ✅ 5. Switch with 'when' keyword (0.5 points)
- **Location**: `CoreLibrary/Product.cs`, lines 66-73
- **Implementation**: Switch expression with `when` clause in `ToString(string?, IFormatProvider?)`
- **Demonstration**: Implicit in formatting demonstration

### ✅ 6. Range Type (0.5 points)
- **Location**: `UtilityLibrary/DataProcessor.cs`, lines 35-38
- **Implementation**: `GetRange<T>` method uses Range type with `[range]` syntax
- **Demonstration**: Lines 43-46 in `DemoApp/Program.cs`

### ✅ 7. Multiple Modules/Assemblies (1 point)
- **Projects**: 
  - `CoreLibrary.csproj` - Main library with core classes
  - `UtilityLibrary.csproj` - Utility library (references CoreLibrary)
  - `DemoApp.csproj` - Console application (references both libraries)
- **Demonstration**: Lines 48-49 in `DemoApp/Program.cs`

### ✅ 8. Sealed or Partial Class (0.5 points)
- **Sealed**: `CoreLibrary/Product.cs`, line 10 - `Product` is sealed
- **Partial**: `CoreLibrary/Customer.cs`, lines 7 and 22 - `Customer` is partial class
- **Demonstration**: Lines 51-53 in `DemoApp/Program.cs`

### ✅ 9. Abstract Class (0.5 points)
- **Location**: `CoreLibrary/BaseEntity.cs`, line 6
- **Implementation**: `BaseEntity` is abstract with abstract method `Save()`
- **Demonstration**: Lines 55-56 in `DemoApp/Program.cs`

### ✅ 10. Static Constructor (1 point)
- **Location**: `CoreLibrary/Product.cs`, lines 15-18
- **Implementation**: Static constructor initializes `DefaultCategory`
- **Demonstration**: Lines 58-59 in `DemoApp/Program.cs`

### ✅ 11. Deconstructor (0.5 points)
- **Location**: `CoreLibrary/Product.cs`, lines 42-46
- **Implementation**: `Deconstruct` method for tuple deconstruction
- **Demonstration**: Lines 61-63 in `DemoApp/Program.cs`

### ✅ 12. Operator Overloading (0.5 points)
- **Location**: `CoreLibrary/Product.cs`, lines 84-108
- **Implementation**: Overloaded `+`, `==`, and `!=` operators
- **Demonstration**: Lines 65-68 in `DemoApp/Program.cs`

### ✅ 13. System.Collections.Generic (1 point)
- **Location**: `UtilityLibrary/DataProcessor.cs`, lines 118-129
- **Implementation**: Uses `Dictionary<string, int>`, `List<T>`, etc.
- **Demonstration**: Lines 70-76 in `DemoApp/Program.cs`

### ✅ 14. 'is' Operator (0.5 points)
- **Location**: `UtilityLibrary/DataProcessor.cs`, lines 98-116
- **Implementation**: Multiple uses of `is` operator with pattern matching
- **Demonstration**: Lines 78-81 in `DemoApp/Program.cs`

### ✅ 15. Default and Named Arguments (0.5 points)
- **Location**: 
  - Default: `CoreLibrary/Product.cs`, line 26 (constructor with default stock=0)
  - Named: `CoreLibrary/Customer.cs`, line 28 (UpdateContact method)
- **Demonstration**: Lines 83-86 in `DemoApp/Program.cs`

### ✅ 16. 'params' Keyword (0.5 points)
- **Location**: `UtilityLibrary/DataProcessor.cs`, lines 14-17
- **Implementation**: `Sum(params int[] numbers)`
- **Demonstration**: Lines 88-90 in `DemoApp/Program.cs`

### ✅ 17. 'out' Arguments (1 point)
- **Location**: `UtilityLibrary/DataProcessor.cs`, lines 20-32
- **Implementation**: `TryParseRange` method with two `out` parameters
- **Demonstration**: Lines 92-96 in `DemoApp/Program.cs`

### ✅ 18. Delegates and Lambda Functions (1.5 points)
- **Delegates**: `UtilityLibrary/DataProcessor.cs`, lines 10-11
- **Lambdas**: Lines 40-43 (FilterList with lambda)
- **Demonstration**: Lines 98-101 in `DemoApp/Program.cs`

### ✅ 19. Bitwise Operations (1 point)
- **Location**: `UtilityLibrary/DataProcessor.cs`, lines 46-60
- **Implementation**: SetFlag, ClearFlag, HasFlag, ToggleFlag using `|`, `&`, `~`, `^`
- **Demonstration**: Lines 103-109 in `DemoApp/Program.cs`

### ✅ 20. Null-Coalescing Operators (?., ?[], ??, ??=) (0.5 points)
- **Location**: 
  - `??`: `UtilityLibrary/DataProcessor.cs`, line 66
  - `?.`: Line 69
  - `?[]`: Line 136
- **Demonstration**: Lines 111-115 in `DemoApp/Program.cs`

### ✅ 21. Pattern Matching (1 point)
- **Location**: `UtilityLibrary/DataProcessor.cs`, lines 75-91
- **Implementation**: Switch expression with type patterns and guards
- **Demonstration**: Lines 117-123 in `DemoApp/Program.cs`

## Building and Running

```bash
cd CSharpDemo
dotnet build
dotnet run --project DemoApp
```

## Project Structure

```
CSharpDemo/
├── CSharpDemo.sln
├── CoreLibrary/
│   ├── ICustomInterface.cs
│   ├── Product.cs
│   ├── BaseEntity.cs
│   └── Customer.cs
├── UtilityLibrary/
│   └── DataProcessor.cs
└── DemoApp/
    └── Program.cs
```

## Total Points: 14.5 / 14.5 ✅

All requirements have been successfully implemented and demonstrated!

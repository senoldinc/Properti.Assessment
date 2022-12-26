# Properti.Assessment
We want to build a calculator in C#. It shall be able to handle
For example:
• Summation
• Multiplication • Division
• Subtraction
• Faculty
• Fractions
• new Sum(5.2, 1.5).toResult() should return 6.7
• new Division(30, new Sum(2, 3)).toResult() should return 6 • new Faculty(4).toResult() should return 24
• new Multiplication(new Fraction(9,4), new
Fraction(2,3)).toResult() should return 1.5
By calling .toResult() on any operation, the corresponding double value shall be returned.
In addition, by calling .print() on any operation, the expression shall be printed in full:
• new Sum(5.2, 1.5).print() should return (5.2 + 1.5) = 6.7 .
• new Division(30, new Sum(2, 3)).print() should return (30 / (2 +
3)) = 6
• new Faculty(4).print() should return (4!) = 24 . • new Multiplication(new Fraction(6,4), new
Fraction(2,3)).print() should return ((9/4) * (2/3)) = 1.5
Moreover, by calling .printSentence(), a sentence shall be printed:
• new Sum(5.2, 1.5).printSentence() should return sum of 5.2 and 1.5 is 6.7 .
• new Division(30, new Sum(2, 3)).printSentence()should return division of 30 by sum of 2 and 3 is 6
• new Faculty(4).printSentence() should return faculty of 4 is 24 . • new Multiplication(new Fraction(6,4), new
Fraction(2,3)).printSentence() should return multiplication of 9/4 and 2/3 is 1.5


*Please be aware that Properti.Assessment are only compatible with .NET 6.0.* 

# Technical Features
- Visual Studio 2022
- .NET 6.0
- C#
- Microsoft.Extensions.Hosting

## Run

Intstall dependencies:
```bash
dotnet restore
```
Build:
```bash
dotnet build
```

Compile and run _(from the root path of the project)_:
```bash
dotnet run
```


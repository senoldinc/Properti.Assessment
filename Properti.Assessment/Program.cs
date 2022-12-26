using Properti.Assessment.Operations;

class Program
{
    static void Main(string[] args)
    {
        //Case 1 - toResult()
        Console.WriteLine(new Sum(5.2, 1.5).toResult()); // should return 6.7
        Console.WriteLine(new Division(30, new Sum(2, 3)).toResult()); // should return 6
        Console.WriteLine(new Faculty(4).toResult()); // should return 24
        Console.WriteLine(new Multiplication(new Fraction(9, 4), new Fraction(2, 3)).toResult()); // should return 1.5
        
        //Case 2 - print()
        Console.WriteLine(new Sum(5.2, 1.5).print()); // should return (5.2 + 1.5) = 6.7
        Console.WriteLine(new Division(30, new Sum(2, 3)).print()); // should return (30 / (2 + 3)) = 6
        Console.WriteLine(new Faculty(4).print()); // should return (4!) = 24
        Console.WriteLine(new Multiplication(new Fraction(9, 4), new Fraction(2, 3)).print()); // should return ((9/4) * (2/3)) = 1.5
        
        //Case 3 - printSentence()
        Console.WriteLine(new Sum(5.2, 1.5).printSentence()); // should return sum of 5.2 and 1.5 is 6.7
        Console.WriteLine(new Division(30, new Sum(2, 3)).printSentence()); // should return division of 30 by sum of 2 and 3 is 6
        Console.WriteLine(new Faculty(4).printSentence()); // should return faculty of 4 is 24
        Console.WriteLine(new Multiplication(new Fraction(9, 4), new Fraction(2, 3)).printSentence()); // should return 9/4 and 2/3 is 1.5
    }
}

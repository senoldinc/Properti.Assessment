using System.Globalization;

namespace Properti.Assessment.Operations;

// Class for multiplication operation
public class Multiplication : IOperation
{
    private IOperation a;
    private IOperation b;

    public Multiplication(IOperation a, IOperation b)
    {
        this.a = a;
        this.b = b;
    }

    public double toResult()
    {
        return a.toResult() * b.toResult();
    }

    public string toStringProcess()
    {
        return $"({a.toStringProcess()} * {b.toStringProcess()})";
    }
    
    public string print()
    {
        return $"{toStringProcess()} = {toResult().ToString(CultureInfo.GetCultureInfo("en-GB"))}";
    }
    
    public string printSentence()
    {
        return $"multiplication of {a.printSentence()} and {b.printSentence()} is {toResult().ToString(CultureInfo.GetCultureInfo("en-GB"))}";
    }
}
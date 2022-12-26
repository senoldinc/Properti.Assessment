using System.Globalization;

namespace Properti.Assessment.Operations;

// Class for faculty operation
public class Faculty : IOperation
{
    private int a;

    public Faculty(int a)
    {
        this.a = a;
    }

    public double toResult()
    {
        double result = 1;
        for (int i = 1; i <= a; i++)
        {
            result *= i;
        }
        return result;
    }

    public string toStringProcess()
    {
        return $"({a}!)";
    }
    
    public string print()
    {
        return $"{toStringProcess()} = {toResult().ToString(CultureInfo.GetCultureInfo("en-GB"))}";
    }

    public string printSentence()
    {
        return $"faculty of {a} is {toResult().ToString(CultureInfo.GetCultureInfo("en-GB"))}";
    }
}

using System.Globalization;
namespace Properti.Assessment.Operations;

// Class for sum operation
public class Sum : IOperation
{
    private double a;
    private double b;

    public Sum(double a, double b)
    {
        this.a = a;
        this.b = b;
    }

    public double toResult()
    {
        return a + b;
    }

    public string toStringProcess()
    {
        //i use the culture for separator shows with dot
        return $"({a.ToString(CultureInfo.GetCultureInfo("en-GB"))} + {b.ToString(CultureInfo.GetCultureInfo("en-GB"))})";
    }

    public string print()
    {
        return $"{toStringProcess()} = {toResult().ToString(CultureInfo.GetCultureInfo("en-GB"))}";
    }
    
    public string printSentence()
    {
        return $"sum of {a.ToString(CultureInfo.GetCultureInfo("en-GB"))} and {b.ToString(CultureInfo.GetCultureInfo("en-GB"))} is {toResult().ToString(CultureInfo.GetCultureInfo("en-GB"))}";
    }
}

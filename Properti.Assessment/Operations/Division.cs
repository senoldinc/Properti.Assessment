using System.Globalization;

namespace Properti.Assessment.Operations;

// Class for division operation
public class Division : IOperation
{
    private double a;
    private IOperation b;

    public Division(double a, IOperation b)
    {
        this.a = a;
        this.b = b;
    }

    public double toResult()
    {
        return a / b.toResult();
    }

    public string toStringProcess()
    {
        return $"({a} / {b.toStringProcess()})";
    }

    public string print()
    {
        //i use the culture for separator shows with dot
        return $"{toStringProcess()} = {toResult().ToString(CultureInfo.GetCultureInfo("en-GB"))}";
    }
    
    public string printSentence()
    {
        return $"division of {a} by sum of {b.toStringProcess().Replace("+", "and").Replace("(","").Replace(")","")} is {toResult().ToString(CultureInfo.GetCultureInfo("en-GB"))}";
    }
}

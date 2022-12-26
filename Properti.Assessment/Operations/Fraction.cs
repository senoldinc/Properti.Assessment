using System.Globalization;

namespace Properti.Assessment.Operations;

// Class for fraction operation
public class Fraction : IOperation
{
    private double numerator;
    private double denominator;

    public Fraction(double numerator, double denominator)
    {
        this.numerator = numerator;
        this.denominator = denominator;
    }

    public double toResult()
    {
        return numerator / denominator;
    }

    public string toStringProcess()
    {
        return $"({numerator}/{denominator})";
    }
    
    public string print()
    {
        return $"{toStringProcess()} = {toResult().ToString(CultureInfo.GetCultureInfo("en-GB"))}";
    }
    
    public string printSentence()
    {
        return $"{numerator}/{denominator}";
    }
}

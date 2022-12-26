using Properti.Assessment.Operations;

namespace Properti.Assessment.Tests;

public class OperationPrintTests
{
    [Test]
    public void TestSumOperationPrint()
    {
        var sum = new Sum(5.2, 1.5);
        Assert.AreEqual("(5.2 + 1.5) = 6.7", sum.print());
    }

    [Test]
    public void TestDivisionOperationPrint()
    {
        var division = new Division(30, new Sum(2, 3));
        Assert.AreEqual("(30 / (2 + 3)) = 6", division.print());
    }

    [Test]
    public void TestFacultyOperationPrint()
    {
        var faculty = new Faculty(4);
        Assert.AreEqual("(4!) = 24", faculty.print());
    }

    [Test]
    public void TestFractionOperationPrint()
    {
        var fraction = new Fraction(9, 4);
        Assert.AreEqual("(9/4) = 2.25", fraction.print());
    }

    [Test]
    public void TestMultiplicationOperationPrint()
    {
        var multiplication = new Multiplication(new Fraction(9, 4), new Fraction(2, 3));
        Assert.AreEqual("((9/4) * (2/3)) = 1.5", multiplication.print());
    }
}
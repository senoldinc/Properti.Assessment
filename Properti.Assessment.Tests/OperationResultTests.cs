using Properti.Assessment.Operations;

namespace Properti.Assessment.Tests;

public class OperationResultTests
{
    [Test]
    public void TestSumOperationResult()
    {
        var sum = new Sum(5.2, 1.5);
        Assert.AreEqual(6.7, sum.toResult());
    }

    [Test]
    public void TestDivisionOperationResult()
    {
        var division = new Division(30, new Sum(2, 3));
        Assert.AreEqual(6, division.toResult());
    }

    [Test]
    public void TestFacultyOperationResult()
    {
        var faculty = new Faculty(4);
        Assert.AreEqual(24, faculty.toResult());
    }

    [Test]
    public void TestFractionOperationResult()
    {
        var fraction = new Fraction(9, 4);
        Assert.AreEqual(2.25, fraction.toResult());
    }

    [Test]
    public void TestMultiplicationOperationResult()
    {
        var multiplication = new Multiplication(new Fraction(9, 4), new Fraction(2, 3));
        Assert.AreEqual(1.5, multiplication.toResult());
    }

}
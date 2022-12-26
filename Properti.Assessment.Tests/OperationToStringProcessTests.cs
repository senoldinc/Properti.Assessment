using Properti.Assessment.Operations;

namespace Properti.Assessment.Tests;

public class OperationToStringProcessTests
{
    [Test]
    public void TestSumOperationToStringProcess()
    {
        var sum = new Sum(5.2, 1.5);
        Assert.AreEqual("(5.2 + 1.5)", sum.toStringProcess());
    }

    [Test]
    public void TestDivisionOperationToStringProcess()
    {
        var division = new Division(30, new Sum(2, 3));
        Assert.AreEqual("(30 / (2 + 3))", division.toStringProcess());
    }

    [Test]
    public void TestFacultyOperationToStringProcess()
    {
        var faculty = new Faculty(4);
        Assert.AreEqual("(4!)", faculty.toStringProcess());
    }

    [Test]
    public void TestFractionOperationToStringProcess()
    {
        var fraction = new Fraction(9, 4);
        Assert.AreEqual("(9/4)", fraction.toStringProcess());
    }

    [Test]
    public void TestMultiplicationOperationToStringProcess()
    {
        var multiplication = new Multiplication(new Fraction(9, 4), new Fraction(2, 3));
        Assert.AreEqual("((9/4) * (2/3))", multiplication.toStringProcess());
    }
}
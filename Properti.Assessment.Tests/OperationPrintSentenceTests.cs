using Properti.Assessment.Operations;

namespace Properti.Assessment.Tests;

public class OperationPrintSentenceTests
{
    [Test]
    public void TestSumOperationPrintSentence()
    {
        var sum = new Sum(5.2, 1.5);
        Assert.AreEqual("sum of 5.2 and 1.5 is 6.7", sum.printSentence());
    }

    [Test]
    public void TestDivisionOperationPrintSentence()
    {
        var division = new Division(30, new Sum(2, 3));
        Assert.AreEqual("division of 30 by sum of 2 and 3 is 6", division.printSentence());
    }

    [Test]
    public void TestFacultyOperationPrintSentence()
    {
        var faculty = new Faculty(4);
        Assert.AreEqual("faculty of 4 is 24", faculty.printSentence());
    }

    [Test]
    public void TestFractionOperationPrintSentence()
    {
        var fraction = new Fraction(9, 4);
        Assert.AreEqual("9/4", fraction.printSentence());
    }

    [Test]
    public void TestMultiplicationOperationPrintSentence()
    {
        var multiplication = new Multiplication(new Fraction(9, 4), new Fraction(2, 3));
        Assert.AreEqual("multiplication of 9/4 and 2/3 is 1.5", multiplication.printSentence());
    }
}
using FactorialLib;

namespace FactorialUT;

[TestClass]
public class UnitTestFactorial
{
    [TestMethod]
    public void TestCalculateFactorialForValidInput()
    {
        int number = 10;
        IFactorial factorial = new Factorial();
        var result = factorial.CalculateFactorial(number);
        Assert.AreEqual(result, 3628800);
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void TestCalculateFactorialForInvalidInput()
    {
        int number = -1;
        IFactorial factorial = new Factorial();
        factorial.CalculateFactorial(number);
    }
}
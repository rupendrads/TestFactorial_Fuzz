using FizzBuzzLib;

namespace FizzBuzzUT;

[TestClass]
public class UnitTestFizzBuzz
{
    [TestMethod]
    public void TestGetFizzBuzzNumbers()
    {
        int start = 1;
        int end = 100;
        int firstMultiplier = 3;
        int secondMultiplier = 5;
        IFizzBuzz fizzBuzz = new FizzBuzz();

        string[] result = fizzBuzz.GetFizzBuzzNumbers(start, end, firstMultiplier, secondMultiplier);

        string[] expectedResult = new string[]{"1","2","Fizz","4","Buzz","Fizz","7","8","Fizz","Buzz",
                                   "11","Fizz","13","14","FizzBuzz","16","17","Fizz","19","Buzz",
                                   "Fizz","22","23","Fizz","Buzz","26","Fizz","28","29","FizzBuzz",
                                   "31","32","Fizz","34","Buzz","Fizz","37","38","Fizz","Buzz",
                                   "41","Fizz","43","44","FizzBuzz","46","47","Fizz","49","Buzz",
                                   "Fizz","52","53","Fizz","Buzz","56","Fizz","58","59","FizzBuzz",
                                   "61","62","Fizz","64","Buzz","Fizz","67","68","Fizz","Buzz",
                                   "71","Fizz","73","74","FizzBuzz","76","77","Fizz","79","Buzz",
                                   "Fizz","82","83","Fizz","Buzz","86","Fizz","88","89","FizzBuzz",
                                   "91","92","Fizz","94","Buzz","Fizz","97","98","Fizz","Buzz"};

        Assert.AreEqual(result.Length, expectedResult.Length);                          
        Assert.AreEqual(result[0], expectedResult[0]);                          
        Assert.AreEqual(result[49], expectedResult[49]);                          
        Assert.AreEqual(result[90], expectedResult[90]);                          
        Assert.AreEqual(result[99], expectedResult[99]);                          
    }
}
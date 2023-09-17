namespace FactorialLib;
public class Factorial: IFactorial
{
    public long CalculateFactorial(int number)
    {
        if (number < 0)
        {
            throw new ArgumentException("Factorial is not defined for negative numbers.");
        }

        long factorial = 1;
        for (int i = 2; i <= number; i++)
        {
            factorial *= i;
        }
        return factorial;
    }
}
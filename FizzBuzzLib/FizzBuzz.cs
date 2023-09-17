using System;

namespace FizzBuzzLib;
public class FizzBuzz: IFizzBuzz
{
    public string[] GetFizzBuzzNumbers(int start, int end, int firstMultiplier, int secondMultiplier)
    {
        int capacity = (end - start) + 1;
        string[] result = new string[capacity];
        for (int i = start; i <= end; i++)
        {
            if (i % firstMultiplier == 0 && i % secondMultiplier == 0)
            {
                result[i-1] = "FizzBuzz"; 
            }
            else if (i % firstMultiplier == 0)
            {
                result[i-1] = "Fizz"; 
            }
            else if (i % secondMultiplier == 0)
            {
                result[i-1] = "Buzz"; 
            }
            else
            {
                result[i-1] = i.ToString();
            }
        }        
        return result;
    }
}

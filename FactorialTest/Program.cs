using Microsoft.Extensions.DependencyInjection;
using FactorialLib;

var serviceProvider = new ServiceCollection()
.AddSingleton<IFactorial, Factorial>()
.BuildServiceProvider();

try
{
    Console.Write("Enter a number to calculate its factorial: ");
    if (int.TryParse(Console.ReadLine(), out int number))
    {
        if (number < 0)
        {
            Console.WriteLine("Factorial is not defined for negative numbers.");
        }
        else
        {
            IFactorial? factorial = serviceProvider.GetService<IFactorial>();
            long factorialResult = factorial.CalculateFactorial(number);
            Console.WriteLine($"Factorial of {number} is {factorialResult}");
        }
    }
    else
    {
        Console.WriteLine("Invalid input. Please enter a valid integer.");
    }
}
catch (Exception ex)
{
    Console.WriteLine($"An error occurred: {ex.Message}");
}

using Microsoft.Extensions.DependencyInjection;
using FizzBuzzLib;

var serviceProvider = new ServiceCollection()
.AddSingleton<IFizzBuzz, FizzBuzz>()
.BuildServiceProvider();

try
{
    IFizzBuzz? fizzBuzz = serviceProvider.GetService<IFizzBuzz>();
    string[] result = fizzBuzz.GetFizzBuzzNumbers(1, 100, 3, 5);
    for (int i = 0; i < result.Length; i++)
    {
        Console.WriteLine(result[i]);        
    }
}
catch (Exception ex)
{
    Console.WriteLine($"An error occurred: {ex.Message}");
}

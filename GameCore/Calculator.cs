namespace GameCore;

public class Calculator
{
    /// <summary>
    /// Adds two integers together
    /// </summary>
    public int Sum(int a, int b)
    {
        int result = a + b;
        Console.WriteLine($"Adding {a} + {b} = {result}");
        return result;
    }

    /// <summary>
    /// Adds multiple integers together
    /// </summary>
    public int Sum(params int[] numbers)
    {
        int result = numbers.Sum();
        Console.WriteLine($"Adding [{string.Join(", ", numbers)}] = {result}");
        return result;
    }

    /// <summary>
    /// Adds two decimal numbers together
    /// </summary>
    public decimal Sum(decimal a, decimal b)
    {
        decimal result = a + b;
        Console.WriteLine($"Adding {a} + {b} = {result}");
        return result;
    }

    /// <summary>
    /// Adds a list of decimal numbers together
    /// </summary>
    public decimal Sum(List<decimal> numbers)
    {
        decimal result = numbers.Sum();
        Console.WriteLine($"Adding [{string.Join(", ", numbers)}] = {result}");
        return result;
    }
} 
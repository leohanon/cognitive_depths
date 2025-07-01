namespace GameCore;

public class Calculator
{
    /// <summary>
    /// Adds two integers together
    /// </summary>
    public int Sum(int a, int b)
    {
        return a + b;
    }

    /// <summary>
    /// Adds multiple integers together
    /// </summary>
    public int Sum(params int[] numbers)
    {
        return numbers.Sum();
    }

    /// <summary>
    /// Adds two decimal numbers together
    /// </summary>
    public decimal Sum(decimal a, decimal b)
    {
        return a + b;
    }

    /// <summary>
    /// Adds a list of decimal numbers together
    /// </summary>
    public decimal Sum(List<decimal> numbers)
    {
        return numbers.Sum();
    }
}

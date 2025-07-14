namespace MCP101;

/// <summary>
/// A simple calculator class that demonstrates basic arithmetic operations.
/// </summary>
public class Calculator
{
    /// <summary>
    /// Adds two numbers together.
    /// </summary>
    /// <param name="a">The first number.</param>
    /// <param name="b">The second number.</param>
    /// <returns>The sum of the two numbers.</returns>
    public double Add(double a, double b)
    {
        return a + b;
    }

    /// <summary>
    /// Subtracts the second number from the first number.
    /// </summary>
    /// <param name="a">The number to subtract from.</param>
    /// <param name="b">The number to subtract.</param>
    /// <returns>The difference between the two numbers.</returns>
    public double Subtract(double a, double b)
    {
        return a - b;
    }
}

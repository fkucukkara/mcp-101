namespace MCP101;

/// <summary>
/// Main program entry point demonstrating the Calculator functionality.
/// </summary>
file sealed class Program
{
    /// <summary>
    /// Entry point for the calculator demonstration application.
    /// Prompts the user for two numbers and performs arithmetic operations.
    /// </summary>
    private static void Main()
    {
        try
        {
            Calculator calculator = new();

            Console.WriteLine("Simple Calculator Demo");
            Console.WriteLine("--------------------");

            Console.Write("Enter first number: ");
            if (!double.TryParse(Console.ReadLine(), out double num1))
            {
                throw new ArgumentException("Invalid first number");
            }

            Console.Write("Enter second number: ");
            if (!double.TryParse(Console.ReadLine(), out double num2))
            {
                throw new ArgumentException("Invalid second number");
            }

            double sum = calculator.Add(num1, num2);
            Console.WriteLine($"{num1} + {num2} = {sum}");

            double difference = calculator.Subtract(num1, num2);
            Console.WriteLine($"{num1} - {num2} = {difference}");

            double product = calculator.Multiply(num1, num2);
            Console.WriteLine($"{num1} * {num2} = {product}");

            double quotient = calculator.Divide(num1, num2);
            Console.WriteLine($"{num1} / {num2} = {quotient}");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Unexpected error: {ex.Message}");
        }
    }
}
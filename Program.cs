  using System;

namespace MCP101;

class Program
{
    static void Main()
    {
        try
        {
            var calculator = new Calculator();
            
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

            // Demo addition
            double sum = calculator.Add(num1, num2);
            Console.WriteLine($"{num1} + {num2} = {sum}");
            
            // Demo subtraction
            double difference = calculator.Subtract(num1, num2);
            Console.WriteLine($"{num1} - {num2} = {difference}");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Unexpected error: {ex.Message}");
        }
    }
}
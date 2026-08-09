namespace HarnessEngineeringAdd;

public static class Program
{
    public static void Main()
    {
        Console.WriteLine("=== Addition of Two Numbers (Harness Engineering) ===");

        var calculator = new Calculator();

        double a = ReadNumber("Enter first number: ");
        double b = ReadNumber("Enter second number: ");

        double sum = calculator.Add(a, b);
        double difference = calculator.Subtract(a, b);

        Console.WriteLine($"Result: {a} + {b} = {sum}");
        Console.WriteLine($"Result: {a} - {b} = {difference}");
    }

    private static double ReadNumber(string prompt)
    {
        while (true)
        {
            Console.Write(prompt);
            string? input = Console.ReadLine();
            if (double.TryParse(input, out double value))
            {
                return value;
            }
            Console.WriteLine("Invalid number, please try again.");
        }
    }
}

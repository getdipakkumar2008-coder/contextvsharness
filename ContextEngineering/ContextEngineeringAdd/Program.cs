// Context Engineering track: everything lives in one file, driven purely
// by the wording of specification.md / Architecture.md / constitution.md.
// No test harness verifies this. Correctness is "trust the prompt".

Console.WriteLine("=== Addition of Two Numbers (Context Engineering) ===");

double a = ReadNumber("Enter first number: ");
double b = ReadNumber("Enter second number: ");

double sum = a + b;
double difference = a - b;
double product = a * b;

Console.WriteLine($"Result: {a} + {b} = {sum}");
Console.WriteLine($"Result: {a} - {b} = {difference}");
Console.WriteLine($"Result: {a} * {b} = {product}");

static double ReadNumber(string prompt)
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

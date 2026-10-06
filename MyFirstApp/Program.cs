using System.Diagnostics.Metrics;

public class Base
{
    public static void Main()
    {
        MyMath math = new MyMath();
        NumberCount countn = new NumberCount();
        Console.WriteLine("Введи числа или exit");
        while (true)
        {
            Console.WriteLine("\nВведи числа:");
            string dataInput = Console.ReadLine();
            
            if (dataInput.ToLower() == "exit")
            {
                Console.WriteLine("\nРабота завершина");
                break;
            }
            double[] numbers = dataInput.Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();
            
            int countNumners = numbers.Length;
            if (countNumners == 0){continue;}
            Console.WriteLine($"Доступные команды: {countn.Counter(countNumners)}");
            
            string Command = Console.ReadLine().ToLower();
            if (Command == "pow" && countNumners == 1)
            {
                Console.WriteLine($"Результат: {math.Power(numbers[0])}");
            }
            else if (Command == "pow" && countNumners == 2)
            {
                Console.WriteLine($"Результат: {math.PowerN(numbers[0], numbers[1])}");
            }
            else if (Command == "sqrt" && countNumners == 1)
            {
                Console.WriteLine($"Результат: {math.Root(numbers[0])}");
            }
            else if (Command == "sqrt" && countNumners == 2)
            {
                Console.WriteLine($"Результат: {math.RootN(numbers[0], numbers[1])}");
            }
            else if (Command == "+")
            {
                Console.WriteLine($"Результат: {math.Add(numbers[0], numbers[1])}");
            }
            else if (Command == "-")
            {
                Console.WriteLine($"Результат: {math.Subtract(numbers[0], numbers[1])}");
            }
            else if (Command == "*")
            {
                Console.WriteLine($"Результат: {math.Multiply(numbers[0], numbers[1])}");
            }
            else if (Command == "/")
            {
                Console.WriteLine($"Результат: {math.Divide(numbers[0], numbers[1])}");
            }
            else if (Command == "sum")
            {
                Console.WriteLine($"Результат: {math.Sum(numbers)}");
            }
            else if (Command == "max")
            {
                Console.WriteLine($"Результат: {math.Max(numbers)}");
            }
            else if (Command == "min")
            {
                Console.WriteLine($"Результат: {math.Min(numbers)}");
            }
            else if (Command == "count")
            {
                Console.WriteLine($"Результат: {math.Count(numbers)}");
            }
            else if (Command == "sort")
            {
                double[] sorted = math.Sort(numbers);
                Console.WriteLine($"Результат: {string.Join(" ", sorted)}");
            }
            else if (Command == "%")
            {
                Console.WriteLine($"Результат: {math.Percent(numbers[0], numbers[1])}");
            }
            else if (Command == "!")
            {
                Console.WriteLine($"Результат: {math.Factorial(numbers[0])}");
            }
            else
            {   
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Неизвестная команда!");
                Console.ResetColor();
            }
        }
    }
}
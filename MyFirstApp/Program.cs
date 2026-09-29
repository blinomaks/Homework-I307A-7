public class Program
{
    public static void Main()
    {
        Program2 math = new Program2();
        int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        
        double SumR = math.Sum(numbers);
        double MaxR = math.Max(numbers);
        double MinR = math.Min(numbers);
        double CountR = math.Count(numbers);

        Console.WriteLine($"{SumR}\n" +
            $"{MaxR}\n" +
            $"{MinR}\n" +
            $"{CountR}");
    }
}
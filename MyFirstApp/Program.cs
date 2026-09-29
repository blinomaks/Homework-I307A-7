public class Base
{
    public static void Main()
    {
        MyMath math = new MyMath();
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
using System.Diagnostics.Metrics;

public class NumberCount
{
    public string Counter(int CountN)
    {
        if (CountN == 1)
        {
            return "pow, sqrt, ! (factorial)";
        }
        else if (CountN == 2)
        {
            return "+, -, *, /, max, min, pow, sqrt, sount, sort";
        }
        else
        {
            return "sum, max, min, sount, sort";
        }
    }
}
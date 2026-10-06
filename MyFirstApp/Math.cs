using System;
using System.Linq;

public class MyMath
{
    public double Sum(double[] nums)
    {
        double result = 0;
        foreach (var num in nums)
        {
            result += num;
        }
        return result;
    }
    public double Max(double[] nums)
    {
        var result = nums[0];
        foreach (var num in nums)
        {
            if (num > result) result = num;
        }
        return result;
    }
    public double Min(double[] nums)
    {
        var result = nums[0];
        foreach (var num in nums)
        {
            if (num < result) result = num;
        }
        return result;
    }
    public double Count(double[] nums)
    {
        return nums.Length;
    }
    public double[] Sort(double[] nums)
    {
        double[] sortedArray = (double[])nums.Clone();
        Array.Sort(sortedArray);
        return sortedArray;
    }
    public double Add(double num1, double num2)
    {
        return num1 + num2;
    }

    public double Subtract(double num1, double num2)
    {
        return num1 - num2;
    }

    public double Multiply(double num1, double num2)
    {
        return num1 * num2;
    }

    public double Divide(double num1, double num2)
    {
        if (num2 == 0) 
        {
            Console.WriteLine("Деление на ноль!");
            return 0; 
        }
        return num1 / num2;
    }
    public double Root(double num)
    {
        return Math.Sqrt(num);
    }
    public double RootN(double num1, double num2)
    {
        return Math.Pow(num1, 1.0 / num2);
    }
    public double Power(double num1)
    {
        return Math.Pow(num1, 2); 
    }
    public double PowerN(double num1, double num2)
    {
        return Math.Pow(num1, num2);
    }
    public double Percent(double num1, double num2)
    {
        return (num1 * num2) / 100.0;
    }
    public double Factorial(double num)
    {
        double result = 1;
        for (int i = 1; i <= (int)num; i++)
        {
            result *= i;
        }
        return result;
    }
}
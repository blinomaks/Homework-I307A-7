using System;
using System.Collections.Generic;
using System.Text;
public class MyMath
{
    public double Sum(int[] nums)
    {
        int result = 0;
        foreach (var num in nums)
        {
            result += num;
        }
        return result;
    }
    public double Max(int[] nums)
    {
        var result = nums[0];
        foreach (var num in nums)
        {
            if (num > result)
            {
                result = num;
            }
        }
        return result;
    }
    public double Min(int[] nums)
    {
        var result = nums[0];
        foreach (var num in nums)
        {
            if (num < result)
            {
                result = num;
            }
        }
        return result;
    }
    public double Count(int[] nums)
    {
        return nums.Length;
    }
}

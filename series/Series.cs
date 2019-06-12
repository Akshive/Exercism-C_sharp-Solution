using System;
using System.Collections.Generic;

public static class Series
{
    public static string[] Slices(string numbers, int sliceLength)
    {
        if(sliceLength > numbers.Length || sliceLength <= 0)
        {
            throw new ArgumentException();
        }
        List<string> res = new List<string>();
        for(int i = 0; i <= (numbers.Length - sliceLength); i++)
        {
            res.Add(numbers.Substring(i, sliceLength));
        }
        return res.ToArray();
    }
}
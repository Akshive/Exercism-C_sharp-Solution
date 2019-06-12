using System;

public static class ReverseString
{
    public static string Reverse(string input)
    {
        if(input == null)return null;
        if(string.Compare(input, "") == 0)return "";
        char[] temp = input.ToCharArray();
        Array.Reverse(temp);
        return new string(temp);
    }
}
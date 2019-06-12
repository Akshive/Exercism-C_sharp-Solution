using System;

public static class Hamming
{
    public static int Distance(string firstStrand, string secondStrand)
    {
        int size = firstStrand.Length;
        if(size != secondStrand.Length)
        {
            throw new ArgumentException();
        }
        int result = 0;
        for(int i = 0; i < size; i++){
            if(firstStrand[i] != secondStrand[i])
            {
                result++;
            }
        }
        return result;
    }
}
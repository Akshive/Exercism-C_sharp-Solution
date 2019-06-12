using System;
using System.Linq;
public static class RnaTranscription
{
    public static string ToRna(string nucleotide)
    {
        if(nucleotide.Length == 0)
        {
            return "";
        }
        Func<char, char> func = fn;
        var res = nucleotide.Select(c => func(arg:c));
        var result = string.Join("", res);
        return result;
    }
    public static char fn(char c)
    {
        if(c=='G')return 'C';
        else if(c=='C')return 'G';
        else if(c=='A')return 'U';
        else return 'A';
    } 
}
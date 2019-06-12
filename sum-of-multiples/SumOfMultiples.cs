using System;
using System.Collections.Generic;
using System.Linq;

public static class SumOfMultiples
{
    public static int Sum(IEnumerable<int> multiples, int max)
    {
        var res = Enumerable.Range(0, max).Where(item => multiples.Any(num => (num != 0 && item%num == 0))).Sum();
        return res;
    }
}
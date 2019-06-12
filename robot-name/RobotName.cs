using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

internal static class RobotExt
{
    public static char NextLetter(this Random r) => (char)('A' + r.Next(25));
    public static char NextNumber(this Random r) => (char)('0' + r.Next(9));
}

public class Robot
{
    private static readonly HashSet<string> History = new HashSet<string>();

    private IEnumerable<string> Generate(Random r)
    {
        while (true)
            yield return $"{r.NextLetter()}{r.NextLetter()}{r.NextNumber()}{r.NextNumber()}{r.NextNumber()}";
    }

    public string Name { get; private set; }

    public void Reset() => Name = Generate(new Random()).First(History.Add);

    public Robot() => Reset();
}
using System;
using System.Collections.Generic;

public static class ResistorColor
{
    private static Dictionary<string, int> colorCodes = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase)
    {
        {"Black", 0},
        {"Brown", 1},
        {"Red", 2},
        {"Orange", 3},
        {"Yellow", 4},
        {"Green", 5},
        {"Blue", 6},
        {"Violet", 7},
        {"Grey", 8},
        {"White", 9}
    };
    private static string[] colors = new string[]{"black", "brown", "red", "orange", "yellow", "green", "blue", "violet", "grey", "white"};
    public static int ColorCode(string color)
    {
        return colorCodes[color];
    }

    public static string[] Colors()
    {
        return colors;
    }
}
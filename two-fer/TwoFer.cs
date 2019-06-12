public static class TwoFer
{
    public static string Speak()
    {
        return "One for you, one for me."
;    }
    public static string Speak(string a)
    {
        return $"One for {a}, one for me.";
    }
}

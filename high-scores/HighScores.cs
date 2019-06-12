using System;
using System.Collections.Generic;
using System.Linq;

public class HighScores
{
    private List<int> scores
    {get; set;}
    public HighScores(List<int> list)
    {
        scores = list;
    }

    public List<int> Scores()
    {
        return scores;
    }

    public int Latest()
    {
        return scores[scores.Count-1];
    }

    public int PersonalBest()
    {
        int Max = Int32.MinValue;
        foreach(int item in scores){
            Max = Math.Max(Max, item);
        }
        return Max;
    }

    public List<int> PersonalTopThree()
    {
        int Max1, Max2, Max3;
        Max1 = Max2 = Max3 = Int32.MinValue;
        foreach(int item in scores){
            if(item > Max1){
                Max3 = Max2;
                Max2 = Max1;
                Max1 = item;
            }
            else if(item > Max2){
                Max3 = Max2;
                Max2 = item;
            }
            else if(item > Max3){
                Max3 = item;
            }
        }

        List<int> res = new List<int>();
        if(scores.Count >= 1)
        {
            res.Add(Max1);
        }
        if(scores.Count >= 2)
        {
            res.Add(Max2);
        }
        if(scores.Count >= 3)
        {
            res.Add(Max3);
        }
        return res;
    }
}
using System;
using System.Collections.Generic;
using System.Linq;

public class HighScores
{
    public List<int> scores ;
    public int highest;
    public int last;

    public HighScores(List<int> scores)
    {
        this.last = scores.Last();
        this.scores = new List<int>(scores);
    }

    public List<int> Scores()
    {
        return this.scores;
    }

    public int Latest()
    {
        return this.scores.Last();
    }

    public int PersonalBest()
    {
        return this.scores.Max();
    }

    public List<int> PersonalTopThree() => scores.OrderByDescending(score => score).Take(3).ToList();
}
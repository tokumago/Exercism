using System;


/// <summary>Class <c>Gigasecond</c> Determine the moment that would be after a gigasecond has passed.</summary>
///
public static class Gigasecond
{
    /// <summary>method <c>Add</c> get the time afer a gigasecond has passed for the <param>moment</param></summary>
    public static DateTime Add(DateTime moment)
    {
        return moment.AddSeconds(1000000000);
    }
}
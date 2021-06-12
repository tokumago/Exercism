using System;

public static class Leap
{
    public static bool IsLeapYear(int year)
    {
       return IsModule(year) && (!IsDiv100(year) || IsDiv400(year));
    }

    public static bool IsModule(int year)
    {
        return year % 4 == 0;
    }

    public static bool IsDiv100(int year)
    {
        return year % 100 == 0;
    }

    public static bool IsDiv400(int year)
    {
        return year % 400 == 0;
    }
}
using System;

public static class ResistorColor
{
    public static int ColorCode(string color)
    {
        string[] arr = Colors();
        for(int i = 0; i < arr.Length; i++)
        {
            if(color.Equals(arr[i]))
            {
                return i;
            }
        }
        return -1;
    }

    public static string[] Colors()
    {
        string[] colors = new string[10]{"black", "brown", "red", "orange", "yellow", "green", "blue", "violet", "grey", "white"};
        return colors;
    }
}
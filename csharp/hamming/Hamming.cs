using System;

public static class Hamming
{
    // Calculate the Hamming Distance between two DNA strands.
    public static int Distance(string firstStrand, string secondStrand)
    {
        if (firstStrand.Length == secondStrand.Length)
        {
            int ham = 0;
            for (int i = 0; i < secondStrand.Length; i++)
            {
                if (!secondStrand[i].Equals(firstStrand[i])) ham++;
            }
            return ham;
        } 
        else
        {
            throw new ArgumentException();
        }
    }

    //public static int Distance(string firstStrand, string secondStrand) {
    //    if (firstStrand.Length != secondStrand.Length) throw new ArgumentException("YOU STUPID!");
    //    return firstStrand.Zip(secondStrand, (s1, s2) => s1 == s2 ? 0 : 1).Sum();
    //}

}
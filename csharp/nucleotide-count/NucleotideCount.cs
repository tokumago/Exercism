using System;
using System.Collections.Generic;

public static class NucleotideCount
{
    // Given a single stranded DNA string, compute how many times each nucleotide occurs in the string.
    public static IDictionary<char, int> Count(string sequence)
    {
        Dictionary<char, int> nucleotide = new Dictionary<char, int>() 
        { 
            {'A', 0},
            {'C', 0},
            {'G', 0},
            {'T', 0},
        };

        foreach (char c in sequence)
        {
            try
            {
                 nucleotide[c] = ++nucleotide[c];
            }
            catch
            {
                throw new ArgumentException("Unewxpected nucleotide value");
            }
        }
        return nucleotide;
    }
}
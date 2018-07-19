using System;
using System.Collections.Generic;
namespace RNATranscriptionModule
{
    public static class RnaTranscription
    {
        public static string ToRna(string nucleotide)
        {
            Dictionary<char, char> dnaToRna = new Dictionary<char, char>();
            dnaToRna.Add('G', 'C');
            dnaToRna.Add('C', 'G');
            dnaToRna.Add('T', 'A');
            dnaToRna.Add('A', 'U');

            char[] dnaArray = nucleotide.ToCharArray();
            char[] rnaArray = new char[dnaArray.Length];
            for (int i = 0; i < dnaArray.Length; i += 1)
            {
                rnaArray[i] = dnaToRna[dnaArray[i]];
            }
            return String.Concat(rnaArray);
            //throw new NotImplementedException("You need to implement this function.");
        }
    }
}

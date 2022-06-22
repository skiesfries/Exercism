using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercism
{
    public static class ProteinTranslation
    {
        static Dictionary<string, string> _CodonsandAminoAcids = new()
        {
            { "AUG", "Methionine" },
            { "UUU", "Phenylalanine" },
            { "UUC", "Phenylalanine" },
            { "UUA", "Leucine" },
            { "UUG", "Leucine" },
            { "UCU", "Serine" },
            { "UCC", "Serine" },
            { "UCA", "Serine" },
            { "UCG", "Serine" },
            { "UAU", "Tyrosine" },
            { "UAC", "Tyrosine" },
            { "UGU", "Cysteine" },
            { "UGC", "Cysteine" },
            { "UGG", "Tryptophan" },
            { "UAA", "STOP" },
            { "UAG", "STOP" },
            { "UGA", "STOP" },

        };
        public static string[] Proteins(string strand)
        {
            List<string> result = new() { };
            List<string> codons = SplitInParts(strand, 3);

            for (int i = 0; i < codons.Count; i++)
            {
                if (_CodonsandAminoAcids.TryGetValue(codons[i], out string aminoAcid))
                {
                    if (aminoAcid == "STOP")
                    {
                        return result.ToArray();
                    }
                    else
                        result.Add(aminoAcid);
                }
            }
            
            return result.ToArray();
        }

        private static List<string> SplitInParts(string stringToBeSplit, int partLength)
        {
            List<string> codons = new() { };
            for (int i = 0; i < stringToBeSplit.Length; i+=3)
            {
                codons.Add(stringToBeSplit.Substring(i, Math.Min(partLength, stringToBeSplit.Length)));
            }
            return codons;
        }

        
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Counting_DNA_Nucleotides
{
    class Program
    {
        static void Main(string[] args)
        {
            string dna = "TGCGGAAAGGTGACATAAATCCTATTCCCTAAAGGAAATGAAGTTGTGAGGAGTCCATATCTTAATGGCTGCGTGAGAGATATACGGTTGATCCGCTCTTATGGCTAGCTTAGACGACGTACACACCGTACTACGTATTCTGAAGCCCCTGGACTCAATAACGCCTCCTTAACTATATGCTGTGTTACGAAGCTGTAACTGCGAACTGAGGCAGGTCTCTGTATAGGTCTAATCTTTAGTTATCCCTGTTTGTCTCATTCGCTTATAAGGAGGGGGGTCCCCTGTGACCTTAACATGCGGGAATAAGGATCCCATGGGAGCAATTTGTCCAGTTGGAATCTATACAGGCGAAACCAACTTCCTGATGTATGTTATGCTCTTGGTCCCAGGCCAAGCTCCGCTTTGACCGTGCCCTGAAGTTGACATTATTATCCGTATCAAAGGAAGGCCTCTTGTACGTGACTGGGCGTGTCAGGTGGCACCTCGTTGACTGTACTAACTCGACCAGGCATTTAGGCATTTCGAACGAACGCCTGGCACTCGCAGCTGCCCCTGTAACACGATCACCTTTTTTCCATTCCCTAAGTAACGCCTGGATGCCGGGAACTTATGACCATAATAGCAAGAGGCCGAAAAAGCGCGAGAGGGAACGCAATACAAGTAGGATGCTGGTCGGAGCTGGCACCGTTGCGCCATTTAACCCTATCAACCCTGCCAATTTTCCAGCTTTCATCCGTGGAAATGCTTAAGACCACTCCACATCGCTCCCCGGGTCTCATAGAGGGGTGTGGCTAGGGTCTTATTCCCCCTGATATGCGTACCCCGCCTAGTCACTTCTTGAACTCATAGTCGCCACATAAGGGCGGACTGACTAATGTTGATTCCCAACGTCAAGAGGGTCCTGTTGTTCGCTCCCTGCCCG";
            int a = 0, c = 0, g = 0, t = 0;
            foreach(char x in dna)
            {
                if (x.ToString() == "A")
                    a++;
                if (x.ToString() == "C")
                    c++;
                if (x.ToString() == "G")
                    g++;
                if (x.ToString() == "T")
                    t++;

            }
            Console.WriteLine(a.ToString() +" "+ c.ToString() + " " + g.ToString() + " " + t.ToString());
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Complementing_a_Strand_of_DNA
{
    class Program
    {
        static void Main(string[] args)
        {
            string dna = "";

            dna = StringHelper.ReverseString(dna);
            dna = dna.Replace("A", "Y");
            dna = dna.Replace("T", "X");
            dna = dna.Replace("Y", "T");
            dna = dna.Replace("X", "A");
            dna = dna.Replace("C", "Y");
            dna = dna.Replace("G", "X");
            dna = dna.Replace("Y", "G");
            dna = dna.Replace("X", "C");

            Console.WriteLine(dna);
            Console.ReadKey();

        }
    }
}

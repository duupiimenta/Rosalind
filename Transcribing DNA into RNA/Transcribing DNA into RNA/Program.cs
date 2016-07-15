using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transcribing_DNA_into_RNA
{
    class Program
    {
        static void Main(string[] args)
        {
            string dna = "";            
            string rna = dna.Replace("T", "U");

            Console.WriteLine(rna);
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemplosBasicos
{
    internal class ExemploMax
    {
        public static void Main(string[] args)
        {
            int[] myNumbers = { 1, 2, 3, 4, 5 };
            Console.WriteLine(myNumbers.Max()); // Retorna o MAIOR número do vetor
        }
    }
}

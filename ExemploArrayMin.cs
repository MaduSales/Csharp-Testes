using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemplosBasicos
{
    internal class ExemploArrayMin
    {
        public static void Main(string[] args)
        {
            int[] myNumbers = { 1, 2, 3, 4, 5, 6 };
            Console.WriteLine(myNumbers.Min()); // Retorna o número mínimo do vetor
        }
    }
}

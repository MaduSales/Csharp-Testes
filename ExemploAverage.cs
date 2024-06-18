using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemplosBasicos
{
    internal class ExemploAverage
    { public static void Main(string[] args)
        {
            int[] numeros = { 1, 45, 95, 12, 681 };
            Console.WriteLine(numeros.Average()); // Faz a média dos números no vetor
        }
    }
}

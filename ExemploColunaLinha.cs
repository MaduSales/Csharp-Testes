using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemplosBasicos
{
    internal class ExemploColunaLinha
    {
        public static void Main(string[] args)
        {
            int[,] numeros = { { 1, 2, 3, 4, 5, 6 }, { 1, 3, 9, 16, 0, 18 } }; // A matriz deve ter a mesma quantidade pra coluna e linha
            Console.WriteLine(numeros[1, 4]); // linha 1 e coluna 4
        }
    }
}

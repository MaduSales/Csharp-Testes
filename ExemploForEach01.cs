using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class ExemploForEach01
    {
        public static void Main(string[] args)
        {
            string[] carro = { "Maria", "Luiza", "Tamires", "Emanuel" };
            foreach (string nomes in carro)
            {
                Console.WriteLine(nomes);
            }
        }
    }
}

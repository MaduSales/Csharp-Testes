using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class ExemploForEach
    {
        public static void Main(string[] args)
        {
            string[] carro = { "Volvo", "BMW", "Ford", "Mazda" };
            foreach (string contadora in carro)
            {
                Console.WriteLine(contadora);
            }
        }
    }
}

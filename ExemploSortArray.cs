using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemplosBasicos
{
    internal class ExemploSortArray
    {
        public static void Main(string[] args)
        {
            string[] myCars = {"Volvo", "Fusca", "BMW"};
            Array.Sort(myCars); //Organiza em ordem alfabética
            foreach (string car in myCars)
            {
                Console.WriteLine(car);
            }
        }
    }
}

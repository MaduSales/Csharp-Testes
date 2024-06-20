using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpCore
{
    class Car
    {
        public string color = "red";
    }
    internal class Automovel
    {

        public static void Main(string[] args)
        {
            Car myObj = new Car();
            Console.WriteLine(myObj.color);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplos
{
    internal class ExemploBreakWhile
    {
        public static void Main(string[] args)
        {
            int i = 0;
            while (i < 10)
            {
                Console.WriteLine(i);
                i++;

                if (i == 5)
                {
                    break;
                }
            }
        }
    }
}

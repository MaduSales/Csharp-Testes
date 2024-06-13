using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplos
{
    internal class ExemploBreakContinue01
    {
        public static void Main(string[] args)
        {
            for (int i = 0; i < 11; i++)
            {
                if (i % 2 != 0)
                {
                    continue;
                }
                Console.WriteLine("Os números pares são " + i);
            }
        }
    }
}

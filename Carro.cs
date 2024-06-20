using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpCore
{
    internal class Carro
    {
        string nome = "Fusca", modelo = "Fusca 1600", cor = "Azul", fabricante = "Volkswagen";
        int ano = 1990;


        public static void Main(string[] args)
        {
            Carro carro01 = new Carro();
            Carro carro02 = new Carro();

            Console.WriteLine(carro01.nome);
            Console.WriteLine(carro02.nome);
            Console.WriteLine(carro01.modelo);
            Console.WriteLine(carro02.modelo);
            Console.WriteLine(carro01.cor);
            Console.WriteLine(carro02.cor);
            Console.WriteLine(carro01.fabricante);
            Console.WriteLine(carro02.fabricante);
            Console.WriteLine(carro01.ano);
            Console.WriteLine(carro02.ano);


        }
    }
}

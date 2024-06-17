using System;

namespace Exemplo07{

    class OperadorAtribuicaoBinario{
        public static void Main(string[] args){
            int num = 6; //0110 em binário
            num &= 3; // 0011 em binário
            // o operador &= faz a operação bitwise AND (bit a bit "E"):

            //0110
            //0011
            //-----
            //0010 (é o número 2 representado em binário)
            Console.WriteLine(num); // deve retornar 2
        }
    }
}
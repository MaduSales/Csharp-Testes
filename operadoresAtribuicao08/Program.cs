using System;

namespace Exemplo08{

    class OperadorAtribuicaoBinarioOu{
        public static void Main(string[] args){

        int num = 5; //0101
        num |= 3; //0011
        //O operador |= é um operador de atribuição bit a bit em Python. Ele realiza uma operação "OU" (OR) bit a bit entre a variável à esquerda e o valor à direita, e depois atribui o resultado de volta à variável à esquerda.

        //0101 (05)
        //0011 (03)
        //-----
        //0111 (número 07 em binário)
        Console.WriteLine(num);
        }
    }
}
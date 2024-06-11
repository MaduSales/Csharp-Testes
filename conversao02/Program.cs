using System;

namespace Exemplo02{

    class Conversao02{
        public static void Main(string[] args){
            double myDouble = 9.78;
            int myInt = (int) myDouble; //conversão de double para inteiro e sendo atribuído à variável Int

            Console.WriteLine(myDouble); // o valor que deve aparecer deve ser o da variável myDoube
            Console.WriteLine(myInt); // o valor que deve aparecer deve ser o que foi atribuído por último para a variável
        }
    }
}
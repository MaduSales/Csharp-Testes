using System;

namespace Exemplo03{

    class Conversao03{
        public static void Main(string[] args){
            int myInt = 9;
            double myDouble = 9.67;
            bool myBool = true;

            Console.WriteLine(Convert.ToString(myInt)); // conversão de inteiro para String
            Console.WriteLine(Convert.ToDouble(myInt)); // conversão de inteiro para double
            Console.WriteLine(Convert.ToInt32(myDouble)); // conversão de double para inteiro
            Console.WriteLine(Convert.ToString(myBool)); // conversão de booleano para string
        }
    }
}
using System;

namespace Desafio
{
    class Program
    {
        static void Main(string[] args)
        {
            // A série de Fibonacci é formada pela seqüência 0,1,1,2,3,5,8,13,21,34,55,...
            // Pesquise como funciona o algoritmo Fibonacci.
            // Faça um programa que gere a série até que o valor seja maior que 500.


            int a = 0, b = 1, c = 0;

            Console.WriteLine("Quantos valores: ");
            int valores = int.Parse(Console.ReadLine());

            Console.WriteLine("Sequência de Fibonaacci com" + valores + " valores");

            for (int i = 0; i < valores; i++)
            {
                if (i < valores - 1){
                    Console.Write(a + ", ");
                }else{
                    Console.Write(a);
                }

                c = a + b;
                a = b;
                b = c;

            }

        }
    }
}

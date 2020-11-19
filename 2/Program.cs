using System;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string usuario;
            string senha;

            do{
                Console.WriteLine("Digite seu login de usúario. ");
                usuario = Console.ReadLine();
                Console.WriteLine();

                Console.WriteLine("Digite sua senha.");
                senha = Console.ReadLine();
                Console.WriteLine();

                if(usuario == senha){
                    Console.WriteLine("ERRO. (A senha não pode ser igual o login) Tente novamente");
                    Console.WriteLine();
                }  

            }while(usuario == senha);
                    Console.WriteLine("Concluído =) ");



        }
    }
}

using System;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
        
        // 1. Nome: diferente de vazio;
        // 2. Idade: entre 0 e 150;
        // 3. Salário: maior que zero;
        // 4. Estado Civil: 's'solteiro(a), 'c'casado(a), 'v'viuvo(a), 'd'divorciado(a);

        string nome;
        int idade;
        float salario;
        string estadoCivil;



            do{
                Console.WriteLine("Digite seu nome.");
                nome = Console.ReadLine();
                Console.WriteLine();

                Console.WriteLine("Digite sua idade.");
                idade = int.Parse(Console.ReadLine());
                Console.WriteLine();

                Console.WriteLine("Digite seu Salário.");
                salario = float.Parse(Console.ReadLine());
                Console.WriteLine();

                Console.WriteLine("Digite seu Estado Civil: 's'solteiro(a), 'c'casado(a), 'v'(viuvo(a), 'd'divorciado(a).;");
                estadoCivil = Console.ReadLine();
                Console.WriteLine();

                if(nome == ""){
                    Console.WriteLine("Defina um nome valido"); nome = "null";
                    Console.WriteLine("*********************");
                }
                if(idade <0 || idade >150){
                    Console.WriteLine("Digite uma idade valida"); idade = 1;
                    Console.WriteLine("*********************");
                }
                if(salario == 0){
                    Console.WriteLine("Digite um salario valido"); salario = 0;
                    Console.WriteLine("*********************");
                }
                if(estadoCivil == "s" || estadoCivil == "c" || estadoCivil == "v" || estadoCivil == "d"){   
                }else{
                    Console.WriteLine("Degite um estado civil valido"); estadoCivil = "null";
                    Console.WriteLine("*********************");
                }

            }while(nome == "null" || idade == 1 || salario == 0 || estadoCivil == "null");

            Console.WriteLine("Concluido, tenha um bom dia =) ");
        }
    }
}

using System;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            int numerotelfn;
            Console.WriteLine("Digite seu número de telefone");
            numerotelfn = int.Parse(Console.ReadLine());
            
            if ((numerotelfn / 1000000 == 91) || (numerotelfn / 1000000 == 99))
            {
                Console.WriteLine("Seu número é da Movicel");

            }
            else 
            {
                Console.WriteLine("Seu número é da Unitel");
                

            }
            
                

            
            Console.ReadKey();
        }

    }
}

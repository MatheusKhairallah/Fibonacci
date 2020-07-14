using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número inteiro: ");
            int numero=Convert.ToInt32(Console.ReadLine());

            int f1=0;
            int f2=1;
            int soma = 0;
            
            for (int i = 0; i < numero; i++)
            {
                Console.Write(soma + " ");
                soma=f1 + f2;
                f2=f1;
                f1=soma;
            }

        }
    }
}

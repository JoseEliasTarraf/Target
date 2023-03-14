using System;

namespace Target2
{
    class Program
    {
        static void Main(string[] args)
        {
            int term1 = 0;
            int term2 = 1;
            int soma = term1 + term2;
            int i;
            int n = int.Parse(Console.ReadLine());
            for(i = 0; i <= 20; i++)
            {
                
                term1 = term2;
                term2 = soma;
                soma = term1 + term2;
                Console.WriteLine(soma);
            }
        }
    }
}

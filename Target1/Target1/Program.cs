using System;

namespace Target1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 13, Soma = 0, K = 0;
            while (K < i)
            {
                K++;
                Soma += K;
            }
            Console.WriteLine(Soma);
        }
    }
}

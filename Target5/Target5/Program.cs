using System;

namespace Target5
{
    class Program
    {
        static void Main(string[] args)
        {
            string st, rst = "";
            Console.Write("Digite uma String:");
            st = Console.ReadLine();

            for(int i = st.Length - 1; i >= 0; i--)
            {
                rst = rst + st[i];
            }
            Console.WriteLine($"String Reverse: {rst}");
        }
    }
}

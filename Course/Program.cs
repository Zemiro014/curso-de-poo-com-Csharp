using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            int variavel = 10;
            Calculadora.Triple(ref variavel);
            Console.WriteLine(variavel);

            int a = 10;
            int triple;
            Calculadora.Triple(a, out triple);
            Console.WriteLine(triple);
        }
    }
}

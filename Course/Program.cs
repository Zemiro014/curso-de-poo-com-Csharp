using System;
using System.Globalization;

namespace Course
{
    class Program
    {       
        static void Main(string[] args)
        {
            Console.WriteLine("Informe a quantidade de pessoas");
            int n = int.Parse(Console.ReadLine());
            double[] vect = new double[n];

            for (int i = 0; i < n; i++) 
            {
                Console.WriteLine("Digite a altura da " + (i + 1) + "ª " + "pessoa");
                vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            double soma = 0;
            for (int i = 0; i < vect.Length; i++)
            {
                soma += vect[i];
            }

            Console.WriteLine("A media das alturas é de " + (soma / vect.Length));
        }
    }
}

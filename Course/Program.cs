using System;
using System.Globalization;

namespace Course
{
    class Program
    {       
        static void Main(string[] args)
        {
            /*
              Nullable: permite fazer com que os tipos valores ( struct) aceitem valor como "null"
             */
            Nullable<double> x = null; // permite que um "double" aceite um valor null
            // também pode ser representado por:
            int? y = null; // permite que um "int" aceite um valor null

            double? a = null;
            double? b = 10.0;

            // Pega o valor da variável, se não tiver pega o valor padrão desta variável
            Console.WriteLine(a.GetValueOrDefault());
            Console.WriteLine(b.GetValueOrDefault());

            // Verifica se nas variáveis existem valores
            Console.WriteLine(a.HasValue);
            Console.WriteLine(b.HasValue);

            // Pega o valor da variável. Resulta numa exceção se o valor da variável for "null"
            if (a.HasValue)
            { Console.WriteLine(a.Value); }
            else 
            {
                Console.WriteLine(" a tem valor null");
            }            
            Console.WriteLine(b.Value);

            Console.WriteLine(" Operador de coalescência nula ");
            // Operador de coalescência nula
            double z = a ?? 5.0; // Significa que: o "z" recebe o valor de "a", mas se o valor de "a" for "null" então o "z" recebe o valor 5.0
            double w = b ?? 2; // Significa que: o "w" recebe o valor de "b", mas se o valor de "b" for "null" então o "w" recebe o valor 2
            Console.WriteLine(z);
            Console.WriteLine(w);
        }
    }
}

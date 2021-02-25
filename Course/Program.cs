
using System;
using System.Globalization;
using System.Collections.Generic;
using Course.LambdaDelegateLinq;

namespace Course
{
    class Program
    {
        // Declarando delegate sem retorno que recebe dois double como parametros.
        delegate void BinaryNumericOperation(double n1, double n2);
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();
            list.Add(new Product("Tv", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.50));
            list.Add(new Product("HD Case", 80.90));

            // Vamos usar o "Predicate" para remover da lista somente aqueles cujo preço mínimo seja 100.

            list.RemoveAll(ProductTest);
                        // Ou
            list.RemoveAll(p => p.Price >= 100.00);

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }

        // Explicando o funcionamento de um "Predicate" usando Lambda
        public static bool ProductTest(Product p)
        {
            return p.Price >= 100;
        }
    }
}

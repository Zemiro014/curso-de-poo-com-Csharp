using Course.Entities.Enums;
using Course.Comparison;
using System;
using System.Globalization;
using System.Collections.Generic;
using Course.Generics;
using Course.GetHashCode_Equals;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product02> list = new List<Product02>();
            list.Add(new Product02("TV", 900.00));
            list.Add(new Product02("Iphone X", 1200.00));
            list.Add(new Product02("Tablet", 450.00));

            /*
                // Fazendo uma comparação dos objectos da nossa lista usando "Delegate"
                Comparison<Product02> comp = CompareProducts; // Definindo um "delegate" atribuindo-lhe uma função declarada "CompareProducts"
                list.Sort(comp);

                Para este caso tivemos que usar uma função declarada "CompareProducts", para realizar um "Sort()" com delegate.

            Outra forma seria usar o "Lambda". Nesta abordagem não precisamos declarar nenhuma função. Nela usamos a função "anonima" 
            */

            /*
                // Usando Lambda:
                Comparison<Product02> comp = (p1, p2) => p1.Name.ToUpper().CompareTo(p2.Name.ToUpper());
                list.Sort(comp);
            */

            // Outra forma de usar Lambda:
            list.Sort((p1, p2) => p1.Name.ToUpper().CompareTo(p2.Name.ToUpper()));

            foreach (Product02 item in list)
            {
                Console.WriteLine(item);
            }
        }

        /*
        static int CompareProducts(Product02 p1, Product02 p2)
        {
            return p1.Name.ToUpper().CompareTo(p2.Name.ToUpper());
        }
        */
    }
}

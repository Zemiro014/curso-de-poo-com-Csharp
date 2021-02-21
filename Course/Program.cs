using System;
using System.Globalization;

namespace Course
{
    class Program
    {       
        static void Main(string[] args)
        {
            // Trabalhando com vectores que recebem tipo class
            Console.WriteLine("Informe a quantidade de produtos");
            int n = int.Parse(Console.ReadLine());
            Produto[] vect = new Produto[n];

            for (int i = 0; i < n; i++) 
            {
                Console.WriteLine("Digite o nome do " + (i + 1) + "º " + "produto");
                string nome = Console.ReadLine();
                Console.WriteLine("Digite o preço do " + (i + 1) + "º " + "produto");
                double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                /*
                 * Pode ser feita deste jeito abaixo: usando construtor automático
                 * vect[i] = new Produto
                 { Nome = nome, Preco = preco };

                 Ou por construtor normal.
                */
                vect[i] = new Produto(nome, preco);

                // A regra é que cada objecto "vect[i]" precisa ser instanciada por "new Produto()" 
            }

            double soma = 0.0;
            for (int i = 0; i < vect.Length; i++)
            {
                soma += vect[i].Preco;
            }

            Console.WriteLine("A media do preço dos produtos é de " + (soma / vect.Length));
        }
    }
}

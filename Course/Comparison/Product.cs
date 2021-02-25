using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Text;

namespace Course.Comparison
{

    /*
     * Definindo uma class que permite ser ordenado (ou comparado) com base a um dos seus atributos (critérios)
     * 
     * O "atributo" escolhido para ser usado na "oredenação" dos objectos desta classe, é drfinido no método "CompareTo()"
     * 
     * O problema de usar esse tipo de abordagem é, se a gente quiser ordenar o objecto com um outro "atributo" (critério), teremos que entrar na classe (Product),
     * e fazer alterações manual no método "CompareTo()". Não é saudável trabalhar deste jeito
     * 
     * A solução viável para isso, está na class "Product02"
     */
    class Product : IComparable<Product>
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public override string ToString()
        {
            return Name
                + ", "
                + Price.ToString("F2", CultureInfo.InvariantCulture);
        }

        // Método que permite definir os critérios de comparação, ou seja, qual atributo da classe será usada para ordena-lo.
        public int CompareTo(Product other)
        {
            return Name.ToUpper().CompareTo(other.Name.ToUpper());
        }
    }
}


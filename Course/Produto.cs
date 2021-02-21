using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Course
{
    class Produto
    {
        private string _nome;

        // Uso de properties auto-implementadas
        public double Preco { get; set; }
        public int Quantidade { get; private set; }

        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }
        public Produto(string nome, double preco)
        {
            _nome = nome;
            Preco = preco;
        }
        public Produto() { }

        // Uso de properties ao invés de getter e setter
        public string Nome
        {
            get { return _nome; }
            set
            {
                if (value != null && value.Length > 1)
                { _nome = value; }
            }
        }

        public double ValorTotalEmEstoque() 
        {
            return Quantidade * Preco;
        }
        public void AdicionarProdutos(int qte)
        {
            if (qte < 0)
            {
                qte = 0;
            }
            Quantidade += qte;
        }

        public void RemoverProdutos(int qte)
        {
            if (Quantidade <= 0)
            {
                Quantidade = 0;
            }
            Quantidade -= qte;
        }

        public override string ToString()
        {
            return _nome
                + ", R$ "
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + Quantidade
                + " unidades, Total: R$ "
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}

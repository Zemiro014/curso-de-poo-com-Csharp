using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Course
{
    class ContaBancaria
    {
        public int Numero { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }

        public ContaBancaria() { }
        public ContaBancaria(string titular, int numero) 
        {
            Numero = numero;
            Titular = titular;
        }
        public ContaBancaria(string titular, int numero, double saldo) : this(titular, numero) 
        {
            Saldo = saldo;
        }
        public void Deposito(double quantia) 
        {
            Saldo += quantia;
        }
        public void Saque(double quantia)
        {
            Saldo -= quantia + 5.0;
        }

        public override string ToString()
        {
            return "Conta: "
                + Numero
                +", Titular: "
                +Titular
                +", Saldo: R$"
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}

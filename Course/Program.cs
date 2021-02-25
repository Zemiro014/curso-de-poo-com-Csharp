using Course.Entities.Enums;
using Course.Entities;
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
            Client a = new Client
            {
                Nome = "Maria",
                Email = "maria@gmail.com"
            };

            Client b = new Client
            {
                Nome = "Alex",
                Email = "alex@gmail.com"
            };

            Console.WriteLine(a.Equals(b));
            Console.WriteLine(a.GetHashCode());
            Console.WriteLine(b.GetHashCode());
        }
    }
}

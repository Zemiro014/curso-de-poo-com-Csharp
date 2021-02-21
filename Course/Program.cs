using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            // Uso de "foreach": usado para percorrer (iterar) uma coleção (vetor; lista e tantas outras coleções). Pode substituir o for
            string[] vect = new string[] { "Maria", "Alex", "Bob" };

            Console.WriteLine("-----------------Usando for--------------");
            for (int i = 0; i < vect.Length; i++)
            {
                Console.WriteLine(vect[i]);
            }
            Console.WriteLine("-----------------Usando foreach--------------");
            foreach (string obj in vect)
            {
                Console.WriteLine(obj);
            }
        }
    }
}

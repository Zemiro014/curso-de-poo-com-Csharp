using Course.Entities.Enums;
using Course.Entities;
using System;
using System.Globalization;
using System.Collections.Generic;
using Course.Generics;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            // PrintServiceString printService = new PrintServiceString();
            //PrintServiceObject printService = new PrintServiceObject();

            PrintServiceGeneric<int> printService = new PrintServiceGeneric<int>();
            Console.WriteLine("How many value?");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++) 
            {
                int x = int.Parse(Console.ReadLine());
                printService.AddValue(x);
            }
            printService.Print();
            Console.WriteLine();
            Console.WriteLine("First: "+printService.First());
        }
    }
}

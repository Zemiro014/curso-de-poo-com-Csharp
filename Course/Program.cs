using System;
using System.Globalization;

namespace Course
{
    class Program
    {       
        static void Main(string[] args)
        {
            // Um struct precisa de ter os seus campos inicializados ou inicializado usando "new Point()" 
            Point p;
            p.X = 10;
            p.Y = 20;
            p = new Point();
            Console.WriteLine(p);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            // Matriz

            double[,] mat = new double[2, 3];

            Console.WriteLine(mat.Length); // Imprime a quantidade de elementos que a matriz tem no total : 2 * 3 = 6
            Console.WriteLine(mat.Rank); // Imprime a primeira dimensão da matriz (quantidade de linhas), que é 2
            Console.WriteLine(mat.GetLength(0)); // Imprime a primeira dimensão da matriz (quantidade de linhas), que é 2
            Console.WriteLine(mat.GetLength(1)); // Imprime a segunda dimensão da matriz (quantidade de colunas), que é 3
        }

    }
}

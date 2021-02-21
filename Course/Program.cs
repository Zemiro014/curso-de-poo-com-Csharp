using System;
using System.Collections.Generic;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            // Trabalhamdo com string

            string original = "abcde FGHIJ ABC abc DEFG     ";

            // converter os valores da variavel "original" em maiúsculo
            string s1 = original.ToUpper();

            Console.WriteLine("original:                            -" + original + "-");
            Console.WriteLine("depois da conversão para maiusculo: -" + s1 + "-");

            // converter os valores da variavel "original" em manúsculo
            string s2 = original.ToLower();
            Console.WriteLine("depois da conversão para minusculo: " + s2 + "-");

            // Apagar os espaços em branco, antes e depois da string
            string s3 = original.Trim();
            Console.WriteLine("depois de apagar os espaços: -" + s3 + "-");

            // Descobrir a primeira ocorrência "bc" na variável "original"
            int n1 = original.IndexOf("bc");
            Console.WriteLine("A primeira ocorrencia foi na posição: " + n1);

            // Descobrir a ultima ocorrência "bc" na variável "original"
            int n2 = original.LastIndexOf("bc");
            Console.WriteLine("A primeira ocorrencia foi na posição: " + n1);

            // Recortar a string da variavel "original"
            string s4 = original.Substring(3); //  Vai gerar uma substring com os valores da variável "original" começando a recortar na posição 3
            Console.WriteLine("Substring gerado" + s4);

            // Recortar a string da variavel "original"
            string s5 = original.Substring(3, 10); //  Vai gerar uma substring com 10 caracteres, começando a recortar na posição 3 da variável "original"
            Console.WriteLine("Substring gerado: " + s5);

            // Sustituir alguns valores de uma string por outros valores
            string s6 = original.Replace('a', 'x'); // Todo local que tiver a, será substituido por x
            Console.WriteLine("depois do replace: " + s6);

            // Sustituir alguns valores de uma string por outros valores
            string s7 = original.Replace("abc", "xy"); // Todo local que tiver a, será substituido por x
            Console.WriteLine("depois do replace: " + s7);

            // testando se a variável é nula ou vazia
            bool b1 = String.IsNullOrEmpty(original);
            Console.WriteLine("IsNullOrEmpty: " + b1);

            // testando se a variável é nula possui espaço em branco
            bool b2 = String.IsNullOrWhiteSpace(original);
            Console.WriteLine("IsNullOrWhiteSpace: " + b2);

        }
    }
}

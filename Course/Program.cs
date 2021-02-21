using System;
using System.Collections.Generic;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            // Usando "List": List é uma coleção variável (dinâmica). Não precisa ser definida o tomanho dela, ou seja o seu tamanho vai com base a necessidade
            List<string> list = new List<string>(); // declarando e inicializando um "List" do tipo string

            // adicionando valores a List declarado e instanciado acima, usando o metodo "add";
            list.Add("Maria");
            list.Add("Alex");
            list.Add("Bob");
            list.Add("Anna");
            list.Add("Iza");
            list.Add("Pedro");
            list.Add("Costa");

            // Inserindo um valor em uma posição especifica di List
            list.Insert(2, "Marcos"); // 
            // list.Insert(6, "Jeronimo");  Vai dar uma exceção pq o index 6 não cosnta no limite da lista 

            // Iterando um List usando foreach e exibindo os valores contido nele
            foreach (string obj in list) { Console.WriteLine(obj); }

            // Pegar o tamanho da lista
            Console.WriteLine("O tamanho (count) da lista é " + list.Count);

            /*
             * Pesquisando um valor na lista (primeira ocorrência que combina com o valor desejado)
             * Usa-se o list.Find(predicate());
             * O "predicate()" podee ser entendido como uma função que recebe uma string e retorna true se nessa string existir um determinado caracter: 
             *      Exemplo: list.Find(Test("A")) vai buscar na "lista" o primeiro elemento que seu valor começa com "A"
             *      
             * O "predicate()" pode ser susbtituido por Lambda: uma função anonima "(x => x[0] == 'A')"; Essa expressão tem a mesma funcionalidade que o método "Test(string s)"
            */
            string s1 = list.Find(x => x[0] == 'A');
            Console.WriteLine("Primeira ocorrência com A da lista é: " + s1);

            /*
             * Buscando a última ocorrencia na lista que o valor começa com A
             */
            string s2 = list.FindLast(x => x[0] == 'A');
            Console.WriteLine("Última ocorrência com A da lista é: " + s2);

            /*
             * Achar a posição do primeiro valor que começa com 'A' na lista
             */
            int s3 = list.FindIndex(x => x[0] == 'A');
            Console.WriteLine("Primeira ocorrência com A da lista, está na posição:  " + s3);
            /*
             * Achar a posição do último valor que começa com 'A' na lista
             */
            int s4 = list.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine("A última ocorrência com A da lista, está na posição:  " + s4);

            // Filtrar a lista: significa que a partir de uma list, criar uma subList que tenha valores que satisfazem a condição do meu "predicate()"
            List<string> list2 = list.FindAll(x => x.Length == 5); // "list2" é uma subList da "list" contendo apenas valores do tamanho 5
            Console.WriteLine("---------------------Exibindo a subList -------------------" );
            foreach (string obj in list2) { Console.WriteLine(obj);}

            // Removendo um elemento específico da lista passando como parâmetro o valor
            list.Remove("Alex");
            Console.WriteLine("---------------------Exibindo o list sem Alex  -------------------");
            foreach (string obj in list) { Console.WriteLine(obj); }

            // Removendo um elemento específico da lista passando como parâmetro o index do valor
            list.RemoveAt(2);
            Console.WriteLine("---------------------Exibindo o list depois de remover o valor do index 2  -------------------");
            foreach (string obj in list) { Console.WriteLine(obj); }

            // Removendo os elementos da lista a partir de uma faixa: Exemplo a partir do index 2 remove os 2 elementes seguidos
            list.RemoveRange(2, 2);
            Console.WriteLine("---------------------Exibindo o list depois de remover os elementos de uma faixa  -------------------");
            foreach (string obj in list) { Console.WriteLine(obj); }

            // Remover todo elemento da lista que satisfazem a condição do meu predicate
            list.RemoveAll(x => x[0] == 'M');
            Console.WriteLine("---------------------Exibindo o list sem os elementos que começam coma letra M  -------------------");
            foreach (string obj in list) { Console.WriteLine(obj); }
        }
        static bool Test(string s) 
        {
            return s[0] == 'A';
        }
    }
}

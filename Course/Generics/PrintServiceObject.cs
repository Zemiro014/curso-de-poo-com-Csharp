using System;
using System.Collections.Generic;
using System.Text;

namespace Course.Generics
{
    /*
     * Essa class resolveria o problema de "reuso" das classes "PrintServiceInt" e "PrintServiceString". Pois ela permite trabalhar com a qualquer tipo de dados.
     * Enquanto que a class "PrintServiceInt" foi codificado para trabalhar com o tipo "int" e a "PrintServiceString" com o tipo "string"
     * 
     * Mas o problema da class "PrintServiceObject" é o "type safety" e a "performance"
     *      Exemplo: Se a gente quisesse atribuir o valor de retorno do método "First()" para uma variável "int",
     *      a gente precisaria fazer uma conversão manual (casting) deste jeito: int x = (int)First(). Para além de não ser bom, ele não oferece a garantia de tipificação,
     *      ou seja, o "compilador" não irá acionar "Error" se o método "First()" retornasse uma "string", O que fará com que o "Error" vá para o tempo de "execução".
     *      
     * A melhor solução seria usar uma classe do tipo <T> como mostra a class "PrintServiceGeneric<T>", que é chamado de classe genérico:
     */
    class PrintServiceObject
    {
        private object[] _values = new object[10];
        private int count = 0;

        public void AddValue(object value)
        {
            if (count == 10)
            {
                throw new InvalidOperationException("PrintService is full");
            }
            _values[count] = value;
            count++;
        }

        public object First()
        {
            if (count == 0)
            {
                throw new InvalidOperationException("PrintService is empty");
            }
            return _values[0];
        }

        public void Print()
        {
            Console.Write("[");
            for (int i = 0; i < count - 1; i++)
            {
                Console.Write(_values[i] + ", ");
            }
            if (count > 0)
            {
                Console.Write(_values[count - 1]);
            }
            Console.Write("]");
        }
    }
}

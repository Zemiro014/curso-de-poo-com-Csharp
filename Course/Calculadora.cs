using System;
using System.Collections.Generic;
using System.Text;

namespace Course
{
    
    class Calculadora
    {
       public static double pi = 3.14;

        public static double Circuferencia(double r)
        {
            return 2 * pi * r;
        }
        public static double Volume(double r)
        {
            return (4.0 / 3.0) * pi * r * r * r;
        }

        // As várias formas de definir função com parâmetros variáveis

        // 1º SobreCarga: Funciona, mas é muioto trabalhoso
        public static int Sum(int n1, int n2)
        {
            return n1 + n2;
        }
        public static int Sum(int n1, int n2, int n3)
        {
            return n1 + n2 + n3;
        }
        public static int Sum(int n1, int n2, int n3, int n4)
        {
            return n1 + n2 + n3 + n4;
        }
        // Termina aqui a sobrecarga de função

        // 2º Uma função que recebe como parãmetro um vector: É bom e funciona. Mas é chato por ter que usar "new int[] {1, 2, 3}" ao chamar ele
        public static int Sum01(int[] numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum;
        }
        

        // 3º Usando o "params" em combinação com um vetor como parametro da função. É bastante prático: permite inserir quantos parâmetros tu desejar.
                // Exemplo: chamando o sum02(1, 2, 3, 4, 5, 6, 7, 8) funcina perfeitamente
        public static int Sum02(params int[] numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum;
        }
        // Termina aqui a definição de função com parâmetros variáveis

        // Modificador de parâmetros ref: trabalha com a refer~encia da variável
        public static void Triple(ref int x)
        {
            x = x * 3;
        }

        // Modificador de parâmetros out: permite que um valor de origem seja passada para outro valor de saída (variável que possui um "out")
        public static void Triple(int origin, out int result)
        {
            result = origin * 3;
        }
    }
}

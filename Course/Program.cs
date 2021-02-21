using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            // soma de 2 números
            int s1 = Calculadora.Sum(2, 3);

            // Usar sobre carga para somar 3 numeros
            int s2 = Calculadora.Sum(2, 3, 4);
            Console.WriteLine("A soma de 2 + 3 é de: "+s1);
            Console.WriteLine("A soma de 2 + 3 + 4 é de: " + s2);
            /*
             * Sobrecarregar métodos é muito trabalhoso. Para solucionar isso ai usa métodos que recebem "vetores". Fazendo isso podemos somar quantos números a gente quiser
             */
            int s3 = Calculadora.Sum01(new int[] { 2, 3, 4, 4, 7, 8 });
            Console.WriteLine("A soma de 2 + 3 + 4 + 4 + 7 + 8 é de: " + s3);

            /*
             Se voce não quer usar veto no argumento de um método, tu pode usar o "Params" no método que recebe o "vetor"
                     Exemplo: public static int Sum02(params int[] numbers) definida na class Calculadora
            O "params" avisa para o compilador que vc quer uma função que possa receber uma quantia variável de parâmetros.
             */
            int s4 = Calculadora.Sum02( 2, 3, 4, 4, 7, 8, 5, 8, 7 );
            Console.WriteLine("A soma de 2 + 3 + 4 + 4 + 7 + 8 é de: " + s4);
        }
    }
}

using Course.Entities.Enums;
using Course.Comparison;
using System;
using System.Globalization;
using System.Collections.Generic;
using Course.Generics;
using Course.GetHashCode_Equals;
using Course.LambdaDelegateLinq;

namespace Course
{
    class Program
    {
        // Declarando delegate sem retorno que recebe dois double como parametros.
        delegate void BinaryNumericOperation(double n1, double n2);
        static void Main(string[] args)
        {
            double a = 10;
            double b = 12;

            /*
             *  Declarando um Multicast Delegate : Usado para guardar referência de duas ou mais funções e executar elas (as funções) na ordem da atribuição.
             *  
             *  É prático usar o Multicast Delegate para funções sem retorno - "Void"
             */
            BinaryNumericOperation op = CalculationService.ShowSum; 
            op += CalculationService.ShowMax;

            op.Invoke(a, b);
        }
    }
}

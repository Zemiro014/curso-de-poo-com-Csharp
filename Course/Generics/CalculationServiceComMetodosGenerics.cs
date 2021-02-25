using System;
using System.Collections.Generic;
using System.Text;

namespace Course.Generics
{
    class CalculationServiceComMetodosGenerics
    {
        public T Max<T>(List<T> list) where T : IComparable
        {
            if (list.Count == 0) {
                throw new ArgumentException("The list can not be empty");
            }

            T max = list[0];
            for (int i = 1; i < list.Count; i++) 
            {
                if (list[1].CompareTo(max) > 0) 
                {
                    max = list[i];
                }
            }
            return max;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Course.Generics
{
    class PrintServiceString
    {
        private string[] _values = new string[10];
        private int count = 0;

        public void AddValue(string value)
        {
            if (count == 10)
            {
                throw new InvalidOperationException("PrintService is full");
            }
            _values[count] = value;
            count++;
        }

        public string First()
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


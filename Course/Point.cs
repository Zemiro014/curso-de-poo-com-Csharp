using System;
using System.Collections.Generic;
using System.Text;

namespace Course
{
    // Para customizar um tipo struct "tipo valor"
    struct Point
    {
        public double X;
        public double Y;

        public override string ToString()
        {
            return "(" + X + ", " + Y + ")";
        }
    }
}

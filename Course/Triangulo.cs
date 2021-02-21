﻿
using System;

namespace Course
{
    class Triangulo
    {
        public double A;
        public double B;
        public double C;

        public double area() 
        {
            double p = (A + B + C) / 2.0;

            double area = Math.Sqrt(p * (p - A) * (p - B) * (p - C));

            return area;
        }
    }
}

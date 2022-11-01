using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Сalculator
{
    public class ClassReferences
    {
        public double Add(double a, double b)
        {
            return a + b;
        }
        public double Sub(double a, double b)
        {
            return a - b;
        }
        public double Div(double a, double b)
        {
            return a / b;
        }
        public double Mult(double a, double b)
        {
            return a * b;
        }
        public double Sin(double s)
        {
            return (Math.Sin(s));
        }
        public double Cos(double s)
        {
            return (Math.Cos(s));
        }
        public double Sqrt( double s)
        {
            return Math.Sqrt(s);
        }
        public double Pov(double a, double b)
        {
            return Math.Pow(a, b);
        }

    }
}
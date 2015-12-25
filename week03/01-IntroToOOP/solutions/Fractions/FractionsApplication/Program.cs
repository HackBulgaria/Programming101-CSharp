using Fractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FractionsApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Fraction a = new Fraction(1, 2);
            a.Denominator = 3;

            Fraction b = new Fraction(4, 6);

            Console.WriteLine(a);
            Console.WriteLine(b);

            Console.WriteLine(a + b);
            Console.WriteLine(a - b);
            Console.WriteLine(a * b);
            Console.WriteLine(a / b);

            Console.WriteLine(a + 2.5);

            Console.WriteLine((double)b);

            Console.WriteLine(a+a == b);

            //Fraction c = new Fraction(3, 0);

            Console.ReadKey();
        }
    }
}
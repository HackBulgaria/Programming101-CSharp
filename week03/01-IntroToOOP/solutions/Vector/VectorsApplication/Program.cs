using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vectors;

namespace VectorsApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Vector a = new Vector(1, 2, 4);
            Vector b = new Vector(2, 2, 0);

            Console.WriteLine(a);
            Console.WriteLine(b);

            Vector c = 2.5 * a + b;
            Console.WriteLine(c);

            Console.WriteLine(a * b);

            Console.WriteLine(b == new Vector(2, 2, 0));

            Console.ReadKey();
        }
    }
}

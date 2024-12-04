using System;
using System.Globalization;
namespace Programa
{
    class Program
    {
        static void Main(string[] args)
        {
            {

                CultureInfo CI = CultureInfo.InvariantCulture;
                float x = 4.5f;
                double y = x;
                Console.WriteLine(y);


                double a;
                float b;
                a = 5.1;
                b = (float)a;
                Console.WriteLine(b);

                double c;
                int d;

                c = 5.1;
                d = (int)c;
                Console.WriteLine(d);

                int e = 5;
                int f = 2;

                double resultado = (double)e / f; 
                Console.WriteLine(resultado);




            }
        }
    }
}
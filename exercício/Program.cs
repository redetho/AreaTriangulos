using System;
using System.Globalization;

namespace exercício
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Triangulo x;
            Triangulo y;
            x = new Triangulo();
            y = new Triangulo();
            

            Console.WriteLine("Entre com as medidas do triângulo X:");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double p = (x.A + x.B + x.C) / 2.0;
            double areaX = Math.Sqrt(p * (p - x.A)* (p - x.B)* (p - x.C));
            

            Console.WriteLine("Entre com as medidas do triângulo Y:");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double d = (x.A + x.B + x.C) / 2.0;
            double areaY = Math.Sqrt(p * (p - y.A) * (p - y.B) * (p - y.C));
            Console.Clear();
            Console.WriteLine("a área do triângulo X é: " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("a área do triângulo Y é: " + areaY.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("a diferença de área dos triângulos é: " + (areaY - areaX).ToString("F4", CultureInfo.InvariantCulture));
            if(areaX > areaY)
            {
                Console.WriteLine("o triângulo maior é X");
            }
            else
            {
                Console.WriteLine("o triângulo maior é Y");
            }
        }
    }
}

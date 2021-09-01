using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Rafael Do Nascimento Rodrigues RA 210211
namespace ConsoleApp2
{
    class Program
    {
       


        
        

        static void Main(string[] args)
        {
            Triangulo x;
            Triangulo y;
            x = new Triangulo();
            y = new Triangulo();

            Console.WriteLine("entre com as medidas do triângulo X: ");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
           Console.WriteLine("entre com as medidas do triângulo Y: ");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            // Calculo area triangulo
            double p = (x.A + x.B + x.C) / 2.0;
            double areaX = Math.Sqrt(p * (p - x.A)* (p - x.B) * (p - x.C));

            Console.WriteLine("A área de x é = " + areaX.ToString("F4", CultureInfo.InvariantCulture));
        
            //Calculo area triangulo
            double q = (y.A + y.B + y.C) / 2.0;
            double areaY = Math.Sqrt(q * (q - y.A) * (q - y.A) * (q - y.A));

            Console.WriteLine("a área de y é = " + areaY.ToString("F4", CultureInfo.InvariantCulture));
            if (areaX > areaY)
            {
                Console.WriteLine("A área de x é maior");
            }
            else if (areaY > areaX)
            {
                Console.WriteLine("A área de y é maior");
            }
            Console.ReadKey();

        }
    }
}

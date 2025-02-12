using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace formula_general
{
     class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("inserte el valor de a");
            double a= double.Parse(Console.ReadLine());
            System.Console.WriteLine("inserte el valor de b");
            double b = double.Parse(Console.ReadLine());
            System.Console.WriteLine("inserte el valor de c");
            double c = double.Parse(Console.ReadLine());
             double R1= Math.Pow(b,2);
            double R2 = 4 * a;
            double R3=R2 * c;
            double R5 = R1 - R3;
            double R4= Math.Sqrt(R5);
            double x1=(-b+R4)/(2*a);
            double  x2=(-b-R4)/(2*a);
            System.Console.WriteLine("el resultado es:" + x1);
            System.Console.WriteLine("el resultado es:" + x2);
            Console.ReadKey();
            
            
        }
    }
}

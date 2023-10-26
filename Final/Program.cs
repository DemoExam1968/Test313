using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x1, y1, x2, y2;
            Random rand = new Random();
            x1 = rand.NextDouble()*100;
            y1 = rand.NextDouble()*100; 
            x2 = rand.NextDouble()*100; 
            y2 = rand.NextDouble()*100;
            Console.WriteLine("(x1, y1) = (" + x1 +", " + y1 +")");
            Console.WriteLine("(x2, y2) = (" + x2 + ", " + y2 + ")");
            double d = Math.Sqrt(Math.Pow(x1-x2,2)+Math.Pow(y1-y2,2));
            Console.WriteLine("Длина отрезка = " + d);
            double c = 2*Math.PI*d;
            Console.WriteLine("Длина окружности = " + c);
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Rayon du cercle ?");
            int r = int.Parse(Console.ReadLine());
            Double perimeter = 2 * Math.PI * r;
            Double surface = r * r * Math.PI;
            Console.WriteLine("Perimeter is = " + perimeter);
            Console.WriteLine("Surface is = " + surface);


        }
    }
}

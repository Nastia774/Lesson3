using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            const float pi = 3.14159265f;

            int r = 5;

            Console.WriteLine($"Плащадь круга={pi*Math.Pow(r,2)} при радиусе r={r}");

            Console.ReadKey();
        }
    }
}

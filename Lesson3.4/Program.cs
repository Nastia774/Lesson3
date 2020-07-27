using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3._4
{
    class Program
    {
        static void Main(string[] args)
        {
            double R = 4, h = 7 ;
            const double pi = 3.14159265;

            Console.WriteLine($"Обьем цилиндра V={pi * Math.Pow(R, 2)*h} при радиусе r={R} и висоте h={h}");
            Console.WriteLine($"Площадь поверхности цилиндра S={2*pi*R*(R+h)}");

            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            int y = 12;
            int z = 3;
            Console.WriteLine("x = 10, y = 12, z = 3");
            {
                x += y - x++ * z;
                Console.WriteLine($"x += y - x++ * z = {x}");
            }
            {
                z = --x - y * 5;
                Console.WriteLine($"z = --x - y * 5 = {z}");
            }
            {
                y /= x + 5 % z;
                Console.WriteLine($"y /= x + 5 % z = {y}");
            }
            {
                z = x++ + y * 5;
                Console.WriteLine($"z = x++ + y * 5 = {z}");
            }

            x = y - x++ * z;
            Console.WriteLine($" x = y - x++ * z = {x}");

            Console.ReadKey();
        }
    }
}

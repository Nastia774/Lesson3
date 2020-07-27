using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3.add
{
    class Program
    {
        static void Main(string[] args)
        {
            int value1 = 2, value2 = 7;

            Console.WriteLine($"Сложение {value1+value2}");

            Console.WriteLine($"Разница {value2-value1}");

            Console.WriteLine($"Умножение {value1*value2}");

            Console.WriteLine($"Деление {value2/value1}");

            Console.WriteLine($"Остаток от деления {value2%value1}");

            Console.ReadKey();
        }
    }
}

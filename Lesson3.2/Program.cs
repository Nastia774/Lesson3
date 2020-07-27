using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            
                int value1 = 3, value2 = 4, value3 = 6;

                Console.WriteLine((value1 + value2 + value3) / 3);
            
            //Даная програма выводит 4 так как округляет до целочисленного значения.
            //Для большей точности переменные должны быть типа с плавающей точкой, так как сам оператор выдает значения входящего типа.
            double value11 = 3, value22 = 4, value33 = 6;
            Console.WriteLine((value11 + value22 + value33) / 3);

            Console.ReadKey();
        }
    }
}

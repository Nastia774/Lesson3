using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3._5
{
    class Program
    {
        static void Main(string[] args)
        {

            int uberflu?;          //В даном случае симвот ? является недопустимым
            int _Identifier;       // Такое допускается, но не желательно   
            int \u006fIdentifier;  // Допускается, но является не желательным
            int &myVar;            //Нельзя так как начинаться с подобных символов названия переменных нельзя. Разрешается ставить на первое место только @ и _
            int myVariab1le;       //Поощряется 

            Console.ReadKey();
        }
    }
}

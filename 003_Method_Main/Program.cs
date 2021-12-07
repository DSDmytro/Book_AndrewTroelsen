using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_Method_Main
{
    class Program
    {
        // Возвращается int, а не void
        static int Main(string[] args)
        {
            Console.WriteLine("***********");
            Console.WriteLine("Hello World");
            Console.WriteLine();
            Console.ReadLine();
            // Возврат произвольного кода ошибки
            return -1;
        }
    }
}

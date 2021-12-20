using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _006_Parse_From_Strings
{
    class Program
    {
        static void ParseFromStrings()
        {
            // Синтаксический разбор типов данных - Парсинг
            Console.WriteLine("Data Type Parsing");
            bool b = bool.Parse("True");
            Console.WriteLine("Value of b: {0}", b);
            double d = double.Parse("99,884");
            Console.WriteLine("Value of d: {0}", d);
            int i = int.Parse("8");
            Console.WriteLine("Value of i: {0}", i);
            char c = char.Parse("w");
            Console.WriteLine("Value of c: {0}", c);
        }
        static void Main(string[] args)
        {
            ParseFromStrings();
        }
    }
}

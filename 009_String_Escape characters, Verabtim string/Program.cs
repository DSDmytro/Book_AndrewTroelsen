using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _009_String_Escape_characters__Verbatim_string
{
    class Program
    {
        static void EscapeChar()
        {
            Console.WriteLine("Escape Characters \a");
            string strWithTabs = "Model \tColor \tSpeed \tPet name";
            Console.WriteLine(strWithTabs);
            Console.WriteLine("Every one loves \"Hello world\"");
            Console.WriteLine("C:\\MyApp\\bin\\Debug");
            Console.WriteLine("\n\n\n\n");
            Console.WriteLine();
        }
        static void VerbatimString()
        {
            Console.WriteLine(@"C:\MyApp\bin\Debug");
            Console.WriteLine(@"This is very 
            very
                very
                    long string");
            Console.WriteLine(@"Cerebus said ""Darrr! Pret-ty sun-sets""");
        }
        static void Main(string[] args)
        {
            EscapeChar();
            Console.WriteLine();
            VerbatimString();
            Console.WriteLine();
        }
    }
}

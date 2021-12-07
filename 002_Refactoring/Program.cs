using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_Refactoring
{
    class Program
    {
        static void Main(string[] args)
        {
            // Настройка консольного интерфейса
            ConfigureCUI();
            Console.ReadLine();

        }

        private static void ConfigureCUI() // Для этого метода использован рефакторинг 
        {
            Console.Title = "My Rocking App";
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("***************************************************************");
            Console.WriteLine("****************** Welcome to My Rocking App ******************");
            Console.WriteLine("***************************************************************");
            Console.BackgroundColor = ConsoleColor.Black;
        }
    }
}

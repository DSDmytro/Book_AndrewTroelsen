using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Basic Console I/O***");
            Console.Beep();
            GetUserData();

            // Некоторые члены класса System.Console
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Red;
            //Console.BackgroundColor = ConsoleColor.Black;
            Console.BufferHeight = 60;
            Console.BufferWidth = 160;
            Console.Title = "My own Title";
            Console.WindowHeight = 20;
            Console.WindowWidth = 100;
            Console.WindowTop = 5; // начальное положение - отступ 5 строк 

            Console.WriteLine("{0}, Number {0}, Number {0}", 9); // пример форматирования вывода с помощью метки-заполнителя
            Console.WriteLine("{1}, {0}, {2}", 10, 20, 30); // пример форматирования вывода с помощью метки-заполнителя


            Console.ReadLine();
        }

        static void GetUserData()
        {
            // Получение информации об имени и возрасте
            Console.Write("Please enter your name: "); // запрос на ввод имени
            string userName = Console.ReadLine();
            Console.Write("Please enter your age: "); // запрос на ввод возраста
            string userAge = Console.ReadLine();
            // Изменение цвета изображения
            ConsoleColor prevColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Yellow;
            // Отображение полученных сведений в окне консоли
            Console.WriteLine("Hello {0}! You are {1} years old.", userName, userAge); // {0},{1} метки-заполнители
            Console.WriteLine($"Hello {userName}! You are {userAge} years old." ); // метки-заполнители внутри стокового литерала




            // Восстановление предыдущего цвета
            Console.ForegroundColor = prevColor;
        }
    }
}

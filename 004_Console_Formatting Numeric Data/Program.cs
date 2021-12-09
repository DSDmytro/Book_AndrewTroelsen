using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; // namespace, подключенна ссылка на System.Windows.Forms

namespace _004_Console_Formatting_Numeric_Data
{
    // Форматирование числовых данных
    class Program
    {
        static void FormatNumericalData()
        {
            Console.WriteLine("***The value 99999 in various formats:");
            Console.WriteLine("c format: {0:c}", 99999);   // форматирование денежных значений, передает символ локальной культуры
            Console.WriteLine("d9 format: {0:d9}", 99999); // минимальное кол-во цифр для предоставления значения
            Console.WriteLine("f3 format: {0:f3}", 99999); // форматирование числовых данных в формате с фиксированной точкой
            Console.WriteLine("n format: {0:n}", 99999);   // базовое числовое форматирование (с запятыми)
            Console.WriteLine("E format: {0:E}", 99999);   // экспоненциальное представление, верхний регистр
            Console.WriteLine("e format: {0:e}", 99999);   // экспоненциальное представление, нижний регистр
            Console.WriteLine("X format: {0:X}", 99999);   // шестнадцатиричный формат, верхний регистр
            Console.WriteLine("x format: {0:x}", 99999);   // шестнадцатиричный формат, нижний регистр
        }
        static void DisplayMessage()
        {
            string userMessage = string.Format("100000 in hex is {0:x}", 100000);
            MessageBox.Show(userMessage);
        }
        static void Main(string[] args)
        {
            FormatNumericalData();
            DisplayMessage();
        }
    }
}

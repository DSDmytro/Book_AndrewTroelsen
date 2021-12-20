using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _007_DateTime__TimeSpan
{
    class Program
    {
        static void UseDatesAndTimes()
        {
            // Отображение значений даты и времени 
            Console.WriteLine("Dates and Times");

            // Этот конструктор принимает в качестве аргументов сведения о годе, месяце, дне
            DateTime dt = new DateTime(2021, 12, 20);

            // Какой это день месяца
            Console.WriteLine("The day of {0} is {1}", dt.Date, dt.DayOfWeek);

            // Прибавляем 2 месяца
            dt = dt.AddMonths(2);
            Console.WriteLine(dt);
            Console.WriteLine("Daylights savings: {0}", dt.IsDaylightSavingTime());

            // Этот конструктор принимает в качестве аргументов сведения о часах, минутах, секундах
            TimeSpan ts = new TimeSpan(4, 30, 0);
            Console.WriteLine("Time: {0}", ts);
            
            // Вычитаем 15 секунл из текущего TimeSpan
            Console.WriteLine(ts.Subtract(new TimeSpan(0, 15, 0)));
        }
        static void Main(string[] args)
        {
            UseDatesAndTimes();
        }
    }
}

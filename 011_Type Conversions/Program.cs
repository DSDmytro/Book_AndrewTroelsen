using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _011_Type_Conversions
{
    class Program
    {
        static int Add(int x, int y)
        {
            return x + y;
        }
        static void NarrowingAttempt()
        {
            byte myByte = 0;
            int myInt = 200; 
            myByte = (byte)myInt; // если значение будет за пределами 255, будет ошибка
            Console.WriteLine("Value 0f myByte {0}", myByte);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("***Type Conversions***");
            short numb1 = 9, numb2 = 10;
            Console.WriteLine("{0} + {1} = {2}", numb1, numb2, Add(numb1, numb2));

            //short numb3 = 3000, numb4 = 30000;
            //short numb5 = Add(numb3, numb4); - ошибка преобразования
            //Console.WriteLine("{0} + {1} = {2}", numb3, numb4, Add(numb3, numb4));
            //Console.ReadLine();

            short numb3 = 30000, numb4 = 30000;
            short numb5 = (short)Add(numb3, numb4); // явное приведение типов
            Console.WriteLine("{0} + {1} = {2}", numb3, numb4, Add(numb3, numb4));

            NarrowingAttempt();
        }
    }
}

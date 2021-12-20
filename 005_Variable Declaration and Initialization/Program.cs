using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005_Variable_Declaration_and_Initialization
{
    class Program
    {
        static void LocalVarDeclarations()
        {
            Console.WriteLine("Data Declarations:");
            int myInt = 0;
            string myString;
            myString = "This is my character data";
            bool b1 = true, b2 = false, b3 = b1; // допускается присваивание сразу нескольких переменных одного базового типа в одной строке
            System.Boolean b4 = false;
            Console.WriteLine("Your data: {0}, {1}, {2}, {3}, {4}, {5}", myInt, myString, b1, b2, b3, b4);
        }
        static void NewingDataTypes()
        {
            // использование конструктора по умолчанию 
            Console.WriteLine("Using new to create variables");
            bool b = new bool();            // установка в false
            int i = new int();              // установка в 0
            double d = new double();        // установка в 0
            DateTime dt = new DateTime();   // установка в 1/1/0001 12:00:00 AM
            Console.WriteLine("{0}, {1}, {2}, {3}", b, i, d, dt);
        }
        static void ObjectFunctionality()
        {
            // Функциональные возможности System.Object
            Console.WriteLine("System.Object Functionality");
            Console.WriteLine("12.GetHashCode() = {0}", 12.GetHashCode());
            Console.WriteLine("12.Equal(23) = {0}", 12.Equals(23));
            Console.WriteLine("12.ToString() = {0}", 12.ToString());
            Console.WriteLine("12.GetType() = {0}", 12.GetType());
        }
        static void DataTypeFunctionality()
        {
            // Функциональные возможности типов данных
            Console.WriteLine("Data Type Functionality");
            Console.WriteLine("Max of int: {0}", int.MaxValue);
            Console.WriteLine("Min of int: {0}", int.MinValue);
            Console.WriteLine("Max of double: {0}", double.MaxValue);
            Console.WriteLine("Min of double: {0}", double.MinValue);
            Console.WriteLine("double.Epsilon: {0}", double.Epsilon);
            Console.WriteLine("double.PositiveInfinity: {0}", double.PositiveInfinity);
            Console.WriteLine("double.NegativeInfinity: {0}", double.NegativeInfinity);
        }
        static void CharFunctionality()
        {
            // Функциональные возможности типа Char
            Console.WriteLine("Char Type Functionality");
            char myChar = 'a';
            Console.WriteLine("char.IsDigit('a'): {0}", char.IsDigit(myChar));
            Console.WriteLine("char.IsLetter('a'): {0}", char.IsLetter(myChar));
            Console.WriteLine("char.IsWhiteSpace('Hello there', 5): {0}", char.IsWhiteSpace("Hello there", 5));
            Console.WriteLine("char.IsWhiteSpace('Hello there', 6): {0}", char.IsWhiteSpace("Hello there", 6));
            Console.WriteLine("char.IsPunctuation('?'): {0}", char.IsPunctuation('?'));
        }
        static void Main(string[] args)
        {
            LocalVarDeclarations();
            Console.WriteLine();
            NewingDataTypes();
            Console.WriteLine();
            ObjectFunctionality();
            Console.WriteLine();
            DataTypeFunctionality();
            Console.WriteLine();
            CharFunctionality();
            Console.WriteLine();
        }
    }
}

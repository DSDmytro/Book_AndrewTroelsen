using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _008_String
{
    class Program
    {
        static void BasicStringFunctionality()
        {
            // Базовые возможности типа String
            Console.WriteLine("Basic String Functionality");
            string firstName = "Freddy";
            Console.WriteLine("Value of firstName: {0}", firstName);
            Console.WriteLine("firstName has {0} characters", firstName.Length);
            Console.WriteLine("firstName in uppercase: {0}", firstName.ToUpper());
            Console.WriteLine("firstName in lowercase: {0}", firstName.ToLower());
            Console.WriteLine("firstName contains the letter 'y'?: {0}", firstName.Contains('y'));
            Console.WriteLine("firstName after replace: {0}", firstName.Replace("dy", ""));
        }
        static void StringConcatenation()
        {
            Console.WriteLine("String Concatenation");
            string s1 = "Programming the ";
            string s2 = "PsychoDrill (PTP)";
            string s3 = s1 + s2;
            string s4 = String.Concat(s1, s2); 
            Console.WriteLine("s3 = s1 + s2: {0}", s3);
            Console.WriteLine("s4 = String.Concat(s1, s2): {0}", s4);
        }
        static void Main(string[] args)
        {
            BasicStringFunctionality();
            Console.WriteLine();
            StringConcatenation();
            Console.WriteLine();
        }
    }
}

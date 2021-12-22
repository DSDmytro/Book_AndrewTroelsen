using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _010_StringBuilder
{
    class Program
    {
        static void FunWithStringBuilder()
        {
            Console.WriteLine("Using the StringBuilder");
            StringBuilder sb = new StringBuilder("***Fantastic Games***");
            sb.Append("\n");
            sb.AppendLine("Half Life");
            sb.AppendLine("Beyond Good and Evil");
            sb.AppendLine("Deus Ex 2");
            sb.AppendLine("System Shock");
            Console.WriteLine(sb.ToString());

            sb.Replace("2", "Invisible War");
            Console.WriteLine(sb.ToString());
            Console.WriteLine("sb has {0} characters", sb.Length);
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            FunWithStringBuilder();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;


            Console.Write("Enter first num of range: ");
            var num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter first num of range: ");
            var num2 = Convert.ToInt32(Console.ReadLine());
            long dobutok = 1;

            if (num2 < num1)
            {
                (num1, num2) = (num2, num1);
            }

            for (int i = num1; i <= num2; i++)
            {
                dobutok *= i;
            }

            Console.WriteLine($"Добуток чисел від {num1} до {num2} дорівнює: {dobutok}");
        }
    }
}

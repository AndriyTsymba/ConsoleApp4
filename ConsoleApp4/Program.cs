using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static  bool FibonacciEquals(int number)
        {

            if (number < 0)
                return false;

            int a = 0;
            int b = 1;

            while (a <= number)
            {
                if (a == number)
                    return true;

                int next = a + b;
                a = b;
                b = next;
            }

            return false;
        }

        static void Main()
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            Console.Write("Enter num: ");
            var num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter range: ");
            var num2 = Convert.ToInt32(Console.ReadLine());

            bool isFibonacci = FibonacciEquals(num1);

            Console.WriteLine(isFibonacci);
        }
    }
}

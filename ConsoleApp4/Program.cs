using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void SortArray(int[] arr, bool ascending)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {

                    if ((ascending && arr[j] > arr[j + 1]) || (!ascending && arr[j] < arr[j + 1]))
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }
        static void PrintArray(int[] arr)
        {
            foreach (int num in arr)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
        static void Main()
        {
            Console.Write("Введіть кількість елементів масиву: ");
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];
            Random rand = new Random();
            for (int i = 0; i < n; i++)
            {
                arr[i] = rand.Next(1, 101); 
            }
            Console.WriteLine("Масив до сортування:");
            PrintArray(arr);
            Console.Write("Виберіть порядок сортування (1 для зростання, 0 для спаду): ");
            int choice = int.Parse(Console.ReadLine());
            SortArray(arr, choice == 1);
            Console.WriteLine("Масив після сортування:");
            PrintArray(arr);
        }
    }
}
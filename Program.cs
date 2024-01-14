using System;
using System.Linq;
using System.Management;
using System.Net;
using System.Net.Http;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;

namespace ConsoleApp1
{
    public class Program
    {

        static void Main(string[] args)
        {

            Console.Write("Введите кол-во элементво массива: ");
            int n = int.Parse(Console.ReadLine()), newArrayCount = 0;
            string[] arr = new string[n];

            for (int i = 0; i < n; ++i)
            {
                Console.Write($"Введите arr[{i}] = ");
                arr[i] = Console.ReadLine();
                if (arr[i].Length <= 3)
                {
                    ++newArrayCount;
                }
            }
            string[] result = new string[newArrayCount];

            Console.WriteLine("Результат: ");
            for (int i = 0, j = 0; i < n && j < newArrayCount; ++i)
            {
                if (arr[i].Length <= 3)
                {
                    Console.WriteLine($"arr[{j}] = {arr[i]}");
                    result[j] = arr[i];
                    ++j;
                }
            }

            Console.Read();
        }
    }

}

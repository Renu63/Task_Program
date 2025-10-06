using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace factorial
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the number of elements to Print : ");
            int num = int.Parse(Console.ReadLine());
            int factorial = 1;
            for (int i = 1; i <= num; i++)
            { 
                factorial *= i;

                Console.WriteLine(factorial);

            }
        }
    }
}


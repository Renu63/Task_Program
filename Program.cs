using System;

namespace fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int num1 = 0, num2 = 1, num3;
            Console.WriteLine("Enter the number of elements to Print : ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                num3 = num1 + num2;
                Console.Write(num3 + " ");
                num1 = num2;
                num2 = num3;
            }
        }
    }
}

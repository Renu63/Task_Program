using System;
using System.Collections.Generic;

namespace evenoddArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            List<int> evenNumbers = new List<int>();
            List<int> oddNumbers = new List<int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    evenNumbers.Add(numbers[i]);
                }
                else
                {
                    oddNumbers.Add(numbers[i]);
                }
            }

            Console.WriteLine("Even Numbers: " + string.Join(" ", evenNumbers));
            Console.WriteLine("Odd Numbers: " + string.Join(" ", oddNumbers));


            Console.ReadKey();
        }
    }
}

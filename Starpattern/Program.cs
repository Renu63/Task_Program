using System;

namespace Starpattern
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter number of rows for Triangle: ");
            int count = Convert.ToInt32(Console.ReadLine());

            int len = 1;

            for (int i = 1; i <= count; i++)
            {
                for (int j = 1; j <= count - i; j++)
                {
                    Console.Write(" ");
                }

                for (int s = 1; s <= len; s++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
                len += 2;
            }

            Console.WriteLine();


            Console.Write("Enter number of rows for Diamond: ");
            int num = int.Parse(Console.ReadLine());

            int diamond = num - 1;

            for (int b = 1; b <= num; b++)
            {
                for (int a = 1; a <= diamond; a++)
                    Console.Write(" ");
                diamond--;
                for (int a = 1; a <= 2 * b - 1; a++)
                    Console.Write("*");
                Console.WriteLine();
            }

            diamond = 1;
            for (int b = 1; b <= num - 1; b++)
            {
                for (int a = 1; a <= diamond; a++)
                    Console.Write(" ");

                diamond++;
                for (int a = 1; a <= 2 * (num - b) - 1; a++)
                    Console.Write("*");
                Console.WriteLine();
            }



            Console.Write("Enter a string: ");
            string input = Console.ReadLine();

            for (int flet = 0; flet < input.Length; flet++)
            {
                for (int l = 1; l <= input.Length - flet; l++)
                {
                   Console.Write(input.Substring(flet, l));
                    Console.WriteLine(" ");
                }
                
            }
        }
    }

}



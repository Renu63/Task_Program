
namespace swap1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int num1 = 90;
            int num2 = 30;
            int temp = 0;

            Console.WriteLine($"Before Swapping num1 = {num1}, num2 = {num2}");

            temp = num1;
            num1 = num2;
            num2 = temp;

            Console.WriteLine($"After Swapping num1 = {num1}, num2 = {num2}");
            Console.ReadKey();
        }
    }
}

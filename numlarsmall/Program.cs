namespace numlarsmall
{
    class program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 22, 13, 25, 69, 84, 0 };
            int maxnum = arr[0];
            int minnum = arr[0];

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > maxnum)
                {
                    maxnum = arr[i];
                }
                else if (arr[i] < minnum)
                { 
                    minnum = arr[i];
                }
            }

            Console.WriteLine("the largest number is: " + maxnum);
            Console.WriteLine("the smallest number is: " + minnum);
        }
    }
}
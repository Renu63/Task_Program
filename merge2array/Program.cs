namespace merge2array
{
    internal class Program
    {
            static void Main(string[] args)
            {
                int[] arr1 = { 11, 12, 3 };
                int[] arr2 = { 14, 5, 16 };

                int[] mergeArray = new int[arr1.Length + arr2.Length];
                for (int i = 0; i < arr1.Length; i++)
                {
                    mergeArray[i] = arr1[i];
                }

                for (int i = 0; i < arr2.Length; i++)
                {
                    mergeArray[arr1.Length + i] = arr2[i];
                }

                Console.WriteLine("Merge Array:");
                for (int i = 0; i < mergeArray.Length; i++)
                {
                    Console.Write(mergeArray[i] + " ");
                }

                Console.ReadKey(); 
            }
    }

}
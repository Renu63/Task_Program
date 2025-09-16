using System;
namespace characterString
{
    class Program
    {
        static void Main()
        {
            string input = "hello";
            Dictionary<char, int> charCount = new Dictionary<char, int>();

            foreach (char c in input)
            {
                if (!charCount.TryAdd(c, 1)) 
                {
                    charCount[c]++;
                }
            }

            foreach (var pair in charCount)
            {
                Console.WriteLine($"'{pair.Key}': {pair.Value}");
            }
        }
    }

}

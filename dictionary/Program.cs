 using System;
 using System.Collections.Generic;

namespace dictionary
{

    class Program
    {
        static void Main()
        {
            string[] words = { "apple", "banana", "apple", "orange", "banana", "apple" };
            Dictionary<string, int> wordCount = new Dictionary<string, int>();

            foreach (string word in words)
            {
                if (!wordCount.TryAdd(word,1))
                {
                    wordCount[word]++;
                }

                //if (wordCount.ContainsKey(word))
                //{
                //    wordCount[word]++;
                //}
                //else
                //{
                //    wordCount[word] = 1;
                //}
            }

            foreach (var pair in wordCount)
            {
                Console.WriteLine($"{pair.Key}: {pair.Value}");
            }
        }
    }
}

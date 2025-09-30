using System.Collections; 
using System; 

namespace duplicatearray
{
    class Program
    {
        static void Main()
        {
            List<int> list = new List<int> { 1, 2, 2, 3, 4, 4, 5, 6, 7, 9, 9 };

            for (int i = 0; i < list.Count; i++)
            {
                for (int j = i + 1; j < list.Count; j++)
                {
                    if (list[i] == list[j])
                    {
                        list.RemoveAt(j);
                        j--;
                    }
                }
            }

            Console.WriteLine("Unique Elements: " + string.Join(", ", list));
        }
    }

}

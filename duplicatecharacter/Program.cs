
namespace duplicatecharacter
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "hello world";
            IEnumerable<char> result = Enumerable.Empty<char>();

            for (int i= 0; i < str.Length; i++) 
                {
                if (!result.Contains(str[i]))
                {
                    result = result.Append(str[i]);
                }
            }

            Console.WriteLine("String without duplicate characters: ");
            Console.WriteLine(string.Join(" ", result));

            Console.ReadKey();
        }
    }
}
  
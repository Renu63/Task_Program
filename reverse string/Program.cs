using System;
using System.Text;

class reverseString
{
    static string reversestring(string s)
    {

        Console.Write("Enter a string to Check Palindrome : ");
        string name = Console.ReadLine();
        StringBuilder res = new StringBuilder();

        for (int i = s.Length - 1; i >= 0; i--)
        {
            res.Append(s[i]);
        }

        return res.ToString();
    }

    static void Main(string[] args)
    {
        string s = "uhuhty";
        string res = reversestring(s);
        Console.WriteLine(res);
    }
}
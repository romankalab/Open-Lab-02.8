using System;

namespace Open_Lab_02._8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string:");
            string word = Console.ReadLine();

            bool result = StringEqual(word);
            Console.WriteLine($"{result}");
        }

        private static bool StringEqual(string word)
        {
            return word == ("");
        }
    }
}

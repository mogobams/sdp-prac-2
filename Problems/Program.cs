using System;

namespace Problems
{
    public class Program
    {
        static void Prefix(string input)
        {
            int length = input.Length;
            int words = input.Split(' ').Length;

            Console.WriteLine(length + "," + words + ":" + input);
        }

        static void Main(string[] args)
        {
            string name = "what  ... did you say?";
            Prefix(name);
        }
    }
}

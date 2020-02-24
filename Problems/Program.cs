using System;

namespace Problems
{
    public class Program
    {
        public string Prefix(string input)
        {
            string result = "";
            int length = input.Length;
            int words = input.Split(new char [] { ' ', '\t'}, StringSplitOptions.RemoveEmptyEntries).Length;

            result = length + "," + words + ":" + input;

            return result;
        }

        static void Main(string[] args)
        {
            Program ans = new Program();
            ans.Prefix("");

        }
    }
}

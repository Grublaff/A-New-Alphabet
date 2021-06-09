using System;
using System.Collections.Generic;

namespace ConsoleApp7
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string temp = string.Empty;
            string input = Console.ReadLine();
            IDictionary<string, string> translations = new Dictionary<string, string>();
            translations.Add("a", "@");
            translations.Add("b", "8");
            translations.Add("c", "(");
            translations.Add("d", "|)");
            translations.Add("e", "3");
            translations.Add("f", "#");
            translations.Add("g", "6");
            translations.Add("h", "[-]");
            translations.Add("i", "|");
            translations.Add("j", "_|");
            translations.Add("k", "|<");
            translations.Add("l", "1");
            translations.Add("m", "[]\\/[]");
            translations.Add("n", "[]\\[]");
            translations.Add("o", "0");
            translations.Add("p", "|D");
            translations.Add("q", "(,)");
            translations.Add("r", "|Z");
            translations.Add("s", "$");
            translations.Add("t", "']['");
            translations.Add("u", "|_|");
            translations.Add("v", "\\/");
            translations.Add("w", "\\/\\/");
            translations.Add("x", "}{");
            translations.Add("y", "`/");
            translations.Add("z", "2");
            translations.Add(" ", " ");
            translations.Add(".", ".");
            translations.Add("!", "!");
            translations.Add("?", "?");
            string result;
            foreach (char item in input)
            {
                if (translations.TryGetValue(item.ToString().ToLower(), out result))
                {
                    temp += result;
                }
                else
                {
                    temp += item.ToString();
                }
            }
            Console.WriteLine(temp);
        }
    }
}
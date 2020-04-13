using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace morse_code
{
    class Program
    {
        static Dictionary<char, string> translator;
        static void Main(string[] args)
        {
            InitialiseDictionary();
            getUserInput();
        }
        private static void InitialiseDictionary()
        {
            char dot = '.';
            char dash = '-';

            translator = new Dictionary<char, string>()
            {
                {'a', string .Concat(dot, dash)},
                {'b', string .Concat(dash, dot, dot , dot)},
                {'c', string .Concat(dash,dot,dash,dot)},
                {'d', string .Concat(dash, dot, dot)},
                {'e', dot.ToString() },
                {'f', string .Concat(dot,dot,dash,dot)},
                {'g', string .Concat(dash,dash,dot)},
                {'h', string .Concat(dot,dot,dot,dot)},
                {'i', string .Concat(dot,dot)},
                {'j', string .Concat(dot,dash,dash,dash)},
                {'k', string .Concat(dash,dot,dash)},
                {'l', string .Concat(dot,dash,dot,dot)},
                {'m', string .Concat(dash,dash)},
                {'n', string .Concat(dash,dot)},
                {'o', string .Concat(dash,dash,dash)},
                {'p', string .Concat(dot,dash,dash,dot)},
                {'q', string .Concat(dash,dash,dot,dash)},
                {'r', string .Concat(dot,dash,dot)},
                {'s', string .Concat(dot,dot,dot)},
                {'t', string .Concat(dash)},
                {'u', string .Concat(dot,dot,dash)},
                {'v', string .Concat(dot,dot,dot,dash)},               
                {'w', string .Concat(dot,dash,dash)},
                {'x', string .Concat(dash,dot,dot,dash)},
                {'y', string .Concat(dash,dot,dash,dash)},
                {'z', string .Concat(dash,dash,dot,dot)},
                {'0', string .Concat(dash,dash,dash,dash,dash)},
                {'1', string .Concat(dot,dash,dash,dash,dash)},
                {'2', string .Concat(dot,dot,dash,dash,dash)},
                {'3', string .Concat(dot,dot,dot,dash,dash)},
                {'4', string .Concat(dot,dot,dot,dot,dash)},
                {'5', string .Concat(dot,dot,dot,dot,dot)},
                {'6', string .Concat(dash,dot,dot,dot,dot)},
                {'7', string .Concat(dash,dash,dot,dot,dot)},
                {'8', string .Concat(dash,dash,dash,dot,dot)},
                {'9', string .Concat(dash,dash,dash,dash,dot)},                                                            
            };
        }
            public static void getUserInput()
            {
            string input;
            Console.WriteLine("enter your word/phrase");
            input = Console.ReadLine();
            input = input.ToLower();
            Console.WriteLine("translation: " + translate(input));
            Console.WriteLine("press enter to end.");
            Console.ReadLine();

        }
        private static string translate(string input)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            foreach (char character in input)
            {
                if (translator.ContainsKey(character))
                {
                    sb.Append(translator[character] + " ");

                }
                else if (character == ' ')
                {
                    sb.Append("/ ");

                }
                else
                {
                    sb.Append(character + " ");

                }
            }
            return sb.ToString();
        }

        

    }
}

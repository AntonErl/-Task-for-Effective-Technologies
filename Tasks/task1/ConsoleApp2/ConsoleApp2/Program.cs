using System;
using System.Collections.Generic;
using System.Linq;


namespace task1
{
    class Program
    {
        static void full_string(string sequence_of_symbols)
        {
            if (sequence_of_symbols.Length<=1)
            {
                Console.WriteLine("The input string is a palindrome");
            }
            else
            {
                bool option = true;
                for (int i = 0; i < sequence_of_symbols.Length / 2; i++)
                {
                    if (sequence_of_symbols[i] != sequence_of_symbols[sequence_of_symbols.Length - i - 1])
                    {
                        option = false;
                    }
                }
                if (option)
                {
                    Console.WriteLine("The input string is a palindrome");
                }
                else
                {
                    Console.WriteLine("the string entered is not a palindrome");
                }
            }
            
        }
        static void unfull_string(string sequence_of_symbols)
        {
            sequence_of_symbols = sequence_of_symbols.Replace(" ", "");

            var x = new HashSet<char>("#@!&?:^%$;№*/-+,.}{)([]|='<>");
            string s = new string(sequence_of_symbols.Where(c => !x.Contains(c)).ToArray());
            Console.WriteLine(s);

            if (sequence_of_symbols.Length <= 1)
            {
                Console.WriteLine("The input string is a palindrome");
            }
            else
            {
                bool option = true;
                for (int i = 0; i < sequence_of_symbols.Length / 2; i++)
                {
                    if (sequence_of_symbols[i] != sequence_of_symbols[sequence_of_symbols.Length - i - 1])
                    {
                        option = false;
                    }
                }
                if (option)
                {
                    Console.WriteLine("The input string is a palindrome");
                }
                else
                {
                    Console.WriteLine("the string entered is not a palindrome");
                }
            }
        }
        static void Main(string[] args)
        {
            bool run = true;
            Console.WriteLine("Is the entered character sequence a palindrome?");
            Console.WriteLine("Enter a sequence of symbols: ");
            string sequence_of_symbols = Console.ReadLine();
            Console.WriteLine("How to explore a string?");
            Console.WriteLine("1 - consider only numbers and letters (ignore spaces, special characters, punctuation, etc.)");
            Console.WriteLine("2 - take into account all the input symbols.");
            int number_of_option = Convert.ToInt32(Console.ReadLine());

            while (run)
            {
                if (number_of_option == 1)
                {
                    unfull_string(sequence_of_symbols);
                }
                if (number_of_option == 2)
                {
                    full_string(sequence_of_symbols);
                }
                Console.WriteLine("want to enter another line? (yes/no)");
                string option  = Console.ReadLine();
                if (option=="yes")
                {
                    Console.WriteLine("Enter a sequence of symbols: ");
                    sequence_of_symbols = Console.ReadLine();
                    Console.WriteLine("How to explore a string?");
                    Console.WriteLine("1 - consider only numbers and letters (ignore spaces, special characters, punctuation, etc.)");
                    Console.WriteLine("2 - take into account all the input symbols.");
                    number_of_option = Convert.ToInt32(Console.ReadLine());
                }
                else
                {
                    run = false;
                }
   
            }
        }

    }
}
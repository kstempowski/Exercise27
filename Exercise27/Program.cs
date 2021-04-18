using System;
using System.Linq;

namespace Exercise27
{
    class Program
    {
        static void Main(string[] args)
        {
            //Set bool to true to being a while loop
            bool repeat = true;
            while (repeat)
            {
                Console.WriteLine("Please enter a word.");
                string words = Console.ReadLine().ToLower();

                //Call the Count Letters method created for this exercise
                string total = CountLetters(words);
                Console.WriteLine($"There are {total} consanants in the word {words}");

                Console.WriteLine("Would you like to input another word? y/n");
                //No matter if capital or lower case is used, a Y/y will return bool true
                string answer = Console.ReadLine().ToLower();

                if (answer == "y")
                {
                    repeat = true;
                }
                //Any answer other than Y/y will return bool false, and the loop will terminate.
                else
                {
                    Console.WriteLine("Goodbye.");
                    repeat = false;
                }
            }
        }

        public static string CountLetters(string word)
        {
            //a => creates a string, and we care telling it that it contains characters bcdfghjklmnpqrstvwxyz
            //we are forcing bcdfghjklmnpqrstvwxyz to lower case to simplify the code/method
            int count = word.Count(a => "bcdfghjklmnpqrstvwxyz".ToLower().Contains(char.ToLower(a)));

            return count.ToString();

        }
    }
}

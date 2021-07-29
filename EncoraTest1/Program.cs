using System;

namespace EncoraTest1
{
    static class Program
    {
        //Added the below constant just in the case you can to run the program and see N times.
        private const int repeater = 7;
        static void Main(string[] args)
        {
            //Add intro messages and awaiting for key to start.
            Console.WriteLine("Hello Encora & CBRE Team!");
            Console.WriteLine("This test was done by Dylan Arroyo.");
            Console.WriteLine("Press any key to start...");
            Console.ReadKey();

            //Request user input for a word to be included in the looper
            var funcTest = makeLooper(cleanInput());
            //Loop to display the results
            for (int i = 0; i < repeater; i++)
            {
                Console.WriteLine(funcTest.Invoke());
            }

            Console.WriteLine("Exercise done.");
            Console.ReadKey();
        }

        /// <summary>
        /// Return a character Function for each char according the index given from the mod result.
        /// </summary>
        /// <param name="text"></param>
        static Func<char> makeLooper(string text)
        {
            //Once the word reaches the end the mod result will be 0 and incremental for every call.
            int idx = 0;
            return () => text[idx++ % text.Length];
        }

        /// <summary>
        /// Alternative way: Return a character Function for each char in the text and reset the index once reaches the end.
        /// </summary>
        /// <param name="text"></param>
        static Func<char> makeLooperAlt(string text)
        {
            int idx = 0;
            char result()
            {
                char rtnChar = text[idx];
                //Calculate index based in the length and reset to 0 once reaches the end.
                idx = (idx == text.Length - 1 ? 0 : ++idx);
                return rtnChar;
            }
            return result;
        }

        static string cleanInput()
        {
            Console.Clear();
            Console.WriteLine("Please enter a word: ");
            return Console.ReadLine();
        }

    }
}

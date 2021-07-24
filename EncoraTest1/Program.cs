using System;

namespace EncoraTest1
{
    static class Program
    {
        private static int index = 0;
        private static string input;
        static void Main(string[] args)
        {
            //Add intro messages and awaiting for key to start.
            Console.WriteLine("Hello Encora Team!");
            Console.WriteLine("This test made by Dylan Arroyo.");
            Console.WriteLine("Press any key to start...");
            Console.ReadKey();
            //Doing a loop when the user wants to try again the exercise.
            bool again = true;
            while (again)
            {
                //Starting a refresh exercise.
                Console.Clear();
                Console.WriteLine("There are two options:");
                Console.WriteLine("Press 1 to do a loop and continues until Escape key is pressed.");
                Console.WriteLine("Press 2 to do a loop and prints the input until reach the end and start back at the beginning");
                var menu = Console.ReadLine();

                //Doing a menu depending on choice and returning if not valid choice.
                switch (menu)
                {
                    case "1":
                        cleanInput();
                        do
                        {
                            Console.WriteLine(makeLooper(input));
                        } while (Console.ReadKey().Key != ConsoleKey.Escape);
                        break;
                    case "2":
                        cleanInput();
                        makeLooperAlt(input);
                        Console.ReadKey();
                        break;
                    default:
                        return;
                }

                //Reading loop choice.
                Console.WriteLine("Do you know to try another phrase? (Y/N)");
                again = Console.ReadLine().Equals("Y", StringComparison.OrdinalIgnoreCase);
            }
        }

        /// <summary>
        /// Returning a string for each char of the text and restating index once reaches the end.
        /// </summary>
        /// <param name="text"></param>
        static string makeLooper(string text)
        {
            //Getting the char according the index given in a continues loop
            var result = text.Substring(index, 1);
            index = text.Length - 1 ==  index ? 0 : ++index;
            return result;
        }

        /// <summary>
        /// Returning a string for each char of the text until reaches end and starts back.
        /// </summary>
        /// <param name="text"></param>
        static string makeLooperAlt(string text)
        {
            //Validate if it's a valid text.
            if (text.Length > 0)
            {
                int i = 0;
                //Loop depending of the length.
                while (i != text.Length + 1)
                {
                    //Validating if i value is equal to the input length then assigning 0 value to start again or increasing i count.
                    var result = i == text.Length
                        ? text.Substring(0, 1)
                        : text.Substring(i, 1);
                    //Printing result and increasing i count.
                    Console.WriteLine(result);
                    i++;
                }
                return "The exercise is completed";
            }
            else
            {
                return "Please give a phrase or word to work.";
            }
        }

        static void cleanInput()
        {
            Console.Clear();
            Console.WriteLine("Please enter a word: ");
            input = Console.ReadLine();
        }

    }
}

using System;

namespace EncoraTest1
{
    static class Program
    {
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
                Console.WriteLine("Please enter a word: ");

                //Calling MakeLooper according user input.
                Console.WriteLine(MakeLooper(Console.ReadLine()));

                //Reading loop choice.
                Console.WriteLine("Do you know to try another phrase? (Y/N)");
                again = Console.ReadLine().Equals("Y", StringComparison.OrdinalIgnoreCase);
            }
        }

        /// <summary>
        /// Returning a string for each char of the text until reaches end and starts back.
        /// </summary>
        /// <param name="text"></param>
        static string MakeLooper(string text)
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

    }
}

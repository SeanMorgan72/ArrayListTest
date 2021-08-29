using System;
using System.Collections.Generic;
using System.Diagnostics;


namespace ArrayTest
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello!  This will be an exerecise in array and list creation!");
            Console.WriteLine();
            Console.WriteLine("Try to get the lowest possible score. . .");
            Console.WriteLine();
            Console.WriteLine("Hit any key to begin the quiz and start the timer");
            Console.ReadLine();

            Stopwatch sw = Stopwatch.StartNew();

            var answer1 = "var numbers = new int[5];";
            var answer2 = "int[] numbers = new int[5];";
            var answer3 = "numbers[0] = 10;";
            var answer4 = "Length";
            var answer5 = "var teachers = new List<string>();";
            var answer6 = "List<string> teachers = new List<string>();";
            var answer7 = "teachers.Add(\"Michael\");";
            var answer8 = "teachers.Remove(\"Michael\");";
            var answer9 = "Count";


            var guess = "";
            var wrongCount = 0;

            do
            {
                Console.WriteLine("Using inferred typing: create a new array named numbers that will hold 5 integers:");
                guess = Console.ReadLine();
                if (guess == answer1)
                {
                    Console.WriteLine("Correct!");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Try again");
                    wrongCount++;
                }

            } while (answer1 != guess);

            do
            {
                Console.WriteLine("Using explicit typing: create a new array named numbers that will hold 5 integers:");
                guess = Console.ReadLine();
                if (guess == answer2)
                {
                    Console.WriteLine("Correct!");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Try again");
                    wrongCount++;
                }

            } while (answer2 != guess);

            do
            {
                Console.WriteLine("Place the value, 10, in the numbers array at index 0:");
                guess = Console.ReadLine();
                if (guess == answer3)
                {
                    Console.WriteLine("Correct!");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Try again");
                    wrongCount++;
                }

            } while (answer3 != guess);

            do
            {
                Console.WriteLine("Complete the code to get the total number of elements in the numbers array");
                Console.WriteLine("numbers.______;");
                guess = Console.ReadLine();
                if (guess == answer4)
                {
                    Console.WriteLine("Correct!");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Try again");
                    wrongCount++;
                }

            } while (answer4 != guess);

            //-------------------------Lists
            do
            {
                Console.WriteLine("Using inferred typing: create a new empty List named teachers that will hold string values:");
                guess = Console.ReadLine();
                if (guess == answer5)
                {
                    Console.WriteLine("Correct!");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Try again");
                    wrongCount++;
                }

            } while (answer5 != guess);

            do
            {
                Console.WriteLine("Using explicit typing: create a new empty List named teachers that will hold string values:");
                guess = Console.ReadLine();
                if (guess == answer6)
                {
                    Console.WriteLine("Correct!");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Try again");
                    wrongCount++;
                }

            } while (answer6 != guess);

            do
            {
                Console.WriteLine("Add the name, Michael, to the teachers list:");
                guess = Console.ReadLine();
                if (guess == answer7)
                {
                    Console.WriteLine("Correct!");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Try again");
                    wrongCount++;
                }

            } while (answer7 != guess);

            do
            {
                Console.WriteLine("Remove the name, Michael, from the teachers list:");
                guess = Console.ReadLine();
                if (guess == answer8)
                {
                    Console.WriteLine("Correct!");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Try again");
                    wrongCount++;
                }

            } while (answer8 != guess);

            do
            {
                Console.WriteLine("The following code will get the number of elements contained in the teachers list");
                Console.WriteLine("and store that integer in a variable named size.");
                Console.WriteLine();
                Console.WriteLine("The code to complete this is missing.");
                Console.WriteLine("What property will complete the code?");
                Console.WriteLine("var size = teachers._______;");
                guess = Console.ReadLine();
                if (guess == answer9)
                {
                    Console.WriteLine("Correct!");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Try again");
                    wrongCount++;
                }

            } while (answer9 != guess);

            var time = sw.Elapsed.TotalSeconds;

            Console.WriteLine("Total seconds to complete:");
            Console.WriteLine(time);

            int score = (int)((time * .4) + (wrongCount * .6));

            Console.WriteLine("Your Score:");
            Console.WriteLine(score);
            Console.ReadLine();

        }
    }
}

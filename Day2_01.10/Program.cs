using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2_01._10
{
    class Program
    {
        static void Main(string[] args)
        {

            /**============================*
            *           ARRAYS            *
            *============================**/

            /**
            * Arrays: stores collection of data (all the same data type)
            *      int[] ages = {0,1,2,3}; //If you know all of the elements already
            *      int[] ages = new int[8]; //If you don't know all of the elements (empty array)
            *      int[] ages = new int[varName] //If you want to set the length later
            **/



            //Console.WriteLine("What is the size of your class? ");

            ////Parse translates a string into an int
            //int classSize = int.Parse(Console.ReadLine());

            //int[] ages = new int[classSize];

            //Several available array methods
            //Console.WriteLine(ages.Max());
            //Console.WriteLine(ages.Min());
            //Console.WriteLine(ages.Average());


            /**============================*
            *           LOOPS            *
            *============================**/

            /**
            * for loop: used when you want to loop a known amount of times
            * foreach loop: used when you want to loop through until end of condition
            * while loop: used when you want to loop until a condition is met
            **/

            //i is a counter (aka "accumulator")

            ////////////// FOR LOOP //////////////
            //for (int i = 0; i < ages.Length; i++)
            //{
            //    Console.WriteLine($"Please enter the age for student {i}: ");
            //use age[i] = int.Parse(Console.ReadLine()); if you are only using it once
            //typically you'll want to go ahead and assign to a variable
            //    int age = int.Parse(Console.ReadLine());
            //    ages[i] = age;

            //    if (i == 2)
            //    {
            //        Console.WriteLine("Magic number 3!");
            //    }
            //    else if (i == 3)
            //    {
            //        Console.WriteLine("Not so magic number 4.");
            //    }
            //}

            ////////////// FOREACH LOOP ///////////////
            //foreach (var age in ages)
            //{
            /**bool isLegal = age >= 21;
            string readableLegal;

            if (isLegal) 
            {
                readableLegal = "Yes";
            }
            else
            {
                readableLegal = "No";
            }**/

            //Lines 88-98 can be replaced by line 100, which is a "turnary" operator 
            //string readableLegal = age >= 21 ? "Yes" : "No";

            //Console.WriteLine($"{age} is legal to drink? {readableLegal} ");
            //Also could use Console.WriteLine($"{age} is legal to drink? {age >= 21}");
            //}

            ///////////////// WHILE LOOP ////////////////
            bool playAgain = true;
            string player = "joel";

            int userGuess;

            while (playAgain)
            {
                Console.WriteLine($"{player} guess a number between 1 and 10: ");
                userGuess = int.Parse(Console.ReadLine());

                if (userGuess <= 5)
                {
                    playAgain = false;
                }
                else
                {
                    //Lines 111-118 can be replaced by a turnary condition (line 220)
                    //if (player == "joel")
                    //{
                    //    player = "sarah";
                    //}
                    //else
                    //{
                    //    player = "joel";
                    //}

                    //Turnary condition: if (player == joel) then set to the last value
                    //                   if (player != joel) then set to the first value
                    player = player == "joel" ? "sarah" : "joel";

                }
            }

            Console.WriteLine($"{player} you have won!");


            //Nesting while loops is not a good idea. If you need multiple whiles, use a method.


            /**============================*
            *           DEBUGGING          *
            *============================**/


            /**
             * Click on the far left gutter to create a "break" (will turn line red)
             *      When you run the program it will turn yellow if it stopped, red if not
             * 
             * While yours program is stopped, you can hover over variables to show the value
             * 
             * Use "Step Over" to progress through your program one line at a time
            **/



            /**============================*
            *           HOMEWORK     1.10  *
            *============================**/

            //WAY ONE

            /*string[] board =
            {
                "_","_","_","_","_","_","_","_","_"
            };

            int counter = 0;
            foreach (string place in board)
            {
                if (counter == 3)
                {
                    Console.WriteLine("");
                    Console.Write(" " + place);
                    counter = 1;
                }
                else
                {
                    Console.Write(" " + place);
                    counter++;
                }
            }
            */

            //WAY TWO
            //string[] board =
            // {
            //     "_","_","_","_","_","_","_","_","_"
            // };

            // int counter = 0;
            // foreach (string place in board)
            // {
            //     Console.Write(" " + place);
            //     if (counter == 2)
            //     {
            //         Console.WriteLine("");
            //         counter = 0;
            //     }
            //     else
            //     {
            //         counter++;
            //     }
            // }



        }


        /**============================*
         *           Extras            *
         *============================**/


        /**
         * string[] is C# array syntax, not .NET
        **/

        /**
             * var = another (lazy) way to declare a variable without
             * explicitly stating the data type but letting the compiler
             * figure out what the data type is
            **/

        //var myString = "joel";

        //Method Signature = the variables that are allowed to go into the method
        //Between the parenthesis of the method
        //var cleanString = myString.Replace('o', '0');

        // User input is always garbage!


    }
}


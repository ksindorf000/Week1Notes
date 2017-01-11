using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1_01._09
{
    class Program
    {
        static void Main(string[] args)
        {

                /**============================*
                 *           STRINGS           *
                 *=============================**/

                //Variables: a way to store data in your computer memory

                //Types: what type of data you want to store in that memory (variable)

                string myString; //Declare the variable type and name
                myString = "My name is Kristin"; //Assigning the value

                string myString2 = "This is more effective";

                //String Concatenation
                Console.WriteLine("Concatenation: " + myString + ". " + myString2);
                Console.ReadLine();
                Console.Clear();

                Console.WriteLine("What is your name?");

                //Get input from user and assign to a variable
                string userString = Console.ReadLine();

                Console.WriteLine("How old are you?");
                int userInt = int.Parse(Console.ReadLine()); //Convert Int to String

                //String Interpolation
                Console.WriteLine($"Interpolation: {userString} is {userInt} years old.");
                Console.WriteLine($"In 10 years, you will be {userInt + 10}.");
                Console.ReadLine();
                Console.Clear();

                //Strings are collections of "char"s (aka "characters")
                char firstLetter = userString[0]; //Index lookup
                int strLength = userString.Length;
                char lastLetter = userString[strLength - 1]; //Length is 1 indexed (meaning it starts at 1)

                Console.WriteLine($"The first letter of your name, {userString}, is {firstLetter}." +
                $"The last letter of your name is {lastLetter}.");

                //Conditionals: Check whether something is true or false
                if (firstLetter.ToString().ToUpper() == "K") //Account for the case of the user input w/o changing value
                {
                    Console.WriteLine("That's the first letter of my name too!");
                }
                else
                {
                    Console.WriteLine("Neat!");
                };

                /**
                 * CTRL + K, CTRL + D = auto formats the code (indentation)
                 * visualstudiosshortcuts.com
                 * "cw" + tab + tab = Console.WriteLine();
                 * RightClick + Rename = rename a variable and apply to all variable referencesin all files
                 * CTRL + K, CTRL + C = comments selection
                 **/

                /**
                 * Types of Numbers: use the right type to optimize your memory usage
                 * byte = small amount of space (digits btwn 0 and 255)
                 **/

                /**
                 * "Stacktrace" is the error that shows in the console when the program 
                 * errors out. Typically, the first few lines are the most helpful.
                 **/

                /**
                 * Compile Time Errors: program will not run
                 * Run Time Errors: program will run but not as expected (aka "bug")
                 **/
            }
        }
}

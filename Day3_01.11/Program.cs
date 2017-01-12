using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3_01._11
{

    /**===========================*
     *           METHODS          *
     *============================**/
    /*
     * A method is a group of code that can be accessed by name.
     * static string ThisMethod (string myString)
     *      static = 
     *      string = data type of returned value, use "void" if no return
     *      ThisMethod = name of the method
     *      (string myString) = Method Signature
     *          declares parameters that are accepted as arguments
    */

    /*
     * Parameter: variable expected by a method (reservation at a restaraunt)
     *      Available to a method definition:
     *          static string ThisMethod (type parameter)
     * Argument: variable passed to a method (guest fulfilling reservation)
     *      Given to a method:
     *          ThisMethod(argument);
     */

    /*
     * Scope: each method has it's own "scope" or information that 
     * is only available to that particular method
     */

    class Program
    {
        static void Main(string[] args)
        {
            string[] board =
             {
                 "_","_","_","_","_","_","_","_","_"
             };

            string data = Input("This is my prompt");

            while (true)
            {
                int location = int.Parse(Console.ReadLine());
                DrawBoard(board);
                board[location] = "X";
            };

        }

        static void DrawBoard(string[] board)
        {
            int counter = 0;
            foreach (string place in board)
            {
                Console.Write(" " + place);
                if (counter == 2)
                {
                    Console.WriteLine("");
                    counter = 0;
                }
                else
                {
                    counter++;
                }
            }
        }

        static string Input(string prompt)
        {
            Console.WriteLine(prompt);
            return Console.ReadLine();
        }

        /**===========================*
            *          TRYPARSE           *
            *============================**/
        /*
         * TryParse() accepts a string, attempts to convert to an integer and pass it back 
         * (just like Parse()),
         * but instead of breaking if the string isn't a number, then it will pass a bool
        */
        public static void TryParse()
        {

            string[] items = { "1", "2", "3" };
            int input = 0;
            items[input] = "X";

            //int num = int.Parse(items[0]); //Error: input string is not in the correct format

            //Can use lines 47-50 OR TryParse (lines 53-54)
            if (items[input] == "X" || items[input] == "O")
            {
                Console.WriteLine("Invalid");
            }

            int result;
            bool valid = int.TryParse(items[input], out result);

        }
    }
}

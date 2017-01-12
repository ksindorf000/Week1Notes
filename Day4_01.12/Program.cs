using System;
using System.IO; //IO = "input output"

/**===========================*
*      USING STATEMENTS       *
*============================**/
/*
 * using NameSpace;
 *      if the NameSpace is white, it's being used.
 *      if the NameSpace is grey, it's not being used
 *      and can be deleted.
*/


namespace Day4_01._12
{
    class Program
    {

        static void Main(string[] args)
        {
            /**===========================*
            *      FILE INPUT/OUTPUT      *
            *============================**/
            /* 
             * Right-click on project name in SE and add a new project item
            */

            Console.WriteLine("Welcome to the program!");
            string[] contents = File.ReadAllLines(@"..\..\namesave.txt"); //Relative file path
                                                                          //Absolute file path @"C:/namesave.txt"
            Console.WriteLine(string.Join(", ", contents));

            /**===========================*
            *           LISTS             *
            *============================**/
            /*
             *
            */

            /**===========================*
            *         RANDOM NUMS         *
            *============================**/
            /*
             *
            */

        }
    }
}

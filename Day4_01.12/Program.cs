using System;
using System.Collections.Generic;
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
            Lists();
        }

        /**===========================*
        *      FILE INPUT/OUTPUT      *
        *============================**/
        /* 
         * Right-click on project name in SE and add a new project item
        */

        public static void FileInputOutput()
        {

            Console.WriteLine("Welcome to the program!");
            string[] contents = File.ReadAllLines(@"..\..\namesave.txt"); //Relative file path
                                                                          //Absolute file path @"C:/namesave.txt"
            Console.WriteLine(string.Join(", ", contents));

        }

        /**===========================*
        *           LISTS             *
        *============================**/
        /*
         * Basically an array but with much more flexibility
         * Array or List? When in doubt, List all the things!
        */

        public static void Lists()
        {
            List<string> myList = new List<string>(); //Create a new instance of an empty list

            myList.Add("joel");
            myList.Add("peanut");
            myList.Add("sara");
            myList.Add("audrey");
            myList.Add("aubrey");

            var myList2 = new List<string>() //Can also use var to cut down on code
            {
                "joel", "peanut", "lincoln"
            };

            string found = myList.Find(x => x.StartsWith("j")); //Preicate: takes a Lambda Expression 
            List<string> foundAll = myList.FindAll(x => x.Length > 4);

            Console.WriteLine(found);
            Console.WriteLine(string.Join(", ", foundAll));


        }

        /**===========================*
        *         RANDOM NUMS         *
        *============================**/
        /*
         *
        */

    }


    /**===========================*
       *         EXTRAS         *
       *============================**/
    /*
     * CTRL + . (Suggested solutions)
     * 
     * "Programs are just collections of bugs that don't exist yet."
     * 
     * <T>: unspecified type 
    */

}

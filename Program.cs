/*

Author: Varghese Charly
Date: 09/22/2020
Purpose: The purpose of this project is to practice using arrays. The project does not take any user input. The code will iterate through the
specified array and print an output for every value in the array.

*/

using System;
using System.Globalization;

namespace Tech_Proj_3B
{
    class Program
    {
        static void Main(string[] args)
        {
            // Letting the user know that there is no need for user input for this program.
            Console.WriteLine("Hello World! No user input is needed here. Just sit back and relax!");

            // CONFIGURATIONS
            // This variable will determine what integer to start populating the array from. Default is 1.
            int startInteger = 1;


            // This specific configuraiton sets the size of the array.
            // The array will be populated with integers that start from "startInteger" and continue till the required number of values in fullfiled.
            int arraySize = 25;

            // Try catch is used incase any errors occur during the execution. This shouldn't be a major issue due to there being no user input.
            try
            {
                /*
                Providing the "PopulateArray" with the preiovusly specified "arraySize" and "startInteger". The output of the method is then given to the "PrintOutput" method.
                */
                PrintOutput(PopulateArray(arraySize, startInteger));
                // Waiting for user acknowledgement before exiting
                Console.ReadKey(true);
            }

            catch
            {
                Console.WriteLine("Error!");
            }
        }

        static int[] PopulateArray(int arraySize, int startInteger)
        {
            int[] fullArray = new int[arraySize];

            for (int i = 0; i < arraySize; i++)
            {
                fullArray[i] = startInteger;
                startInteger++;
            }

            return fullArray;

        }

        static void PrintOutput(int[] fullArray)
        {
            foreach (int i in fullArray)
            {
                Console.WriteLine("Element value = " + i.ToString());
            }
        }
    }
}

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


            // This specific configuration sets the size of the array.
            // The array will be populated with integers that start from "startInteger" and continue till the required number of values in fulfilled.
            int arraySize = 25;

            // Try catch is used in case any errors occur during the execution. This should not be a major issue due to there being no user input.
            try
            {
                /*
                Providing the "PopulateArray" with the previously specified "arraySize" and "startInteger". The output of the method is then given to the "PrintOutput" method.
                */
                PrintOutput(PopulateArray(arraySize, startInteger));
                // Waiting for user acknowledgement before exiting
                Console.ReadKey(true);
            }

            // Catch will trigger if any errors occur during execution on the try section
            catch
            {
                // Prompting the user to reopen the application to try again
                Console.WriteLine("An error has occured, please reopen the program to try again.");
                Console.WriteLine("Press any key to continue...");
                // Waiting for user input before closing
                Console.ReadKey(true);
            }
        }

        // Method used to populate the array. The array's desired size and the starting integer of the array is provided to the method.
        static int[] PopulateArray(int arraySize, int startInteger)
        {
            // Initializing an integer array with the specified array size provided in the input
            int[] fullArray = new int[arraySize];

            // Using "i" as a reference for the index of the array. Setting the index to 0 and incrementing up until the required array size is met.
            for (int i = 0; i < arraySize; i++)
            {
                // Setting the array to the value of the startInteger variable.
                fullArray[i] = startInteger;
                // Incrementing the value of the startInteger so that it counts up. The start integer will increment instead of using another variable for this to save space.
                startInteger++;
            }

            // The method is going to return the array filled with the values using the specified requirements of starting integer and array size.
            return fullArray;

        }

        // Method used to loop through the array indexes and print the values of each index.
        static void PrintOutput(int[] fullArray)
        {
            // Using a foreach loop to increment through all of the indexes in the fullArray array. The index is specified with the variable i.
            foreach (int i in fullArray)
            {
                // Printing the value held within each index.
                Console.WriteLine("Element value = " + i.ToString());
            }
        }
    }
}


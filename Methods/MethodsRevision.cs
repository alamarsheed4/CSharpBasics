using System;
using System.Net.Http.Headers;

namespace MathProgram
{

    /* 
     * Note : Here try to understand the program
     * */

    class Program
    {
        // Method that processes an integer array and returns a string array
        static string[] ProcessArray(int[] numbers)
        {
            // Create a string array to store results
            string[] results = new string[numbers.Length];

            // so here i can store the 5 string values.... i mean i can keep 5 string values.

            // Even i can take the 5 but its hard coded value . so i am taking the numbers.lentgh

            
            //Here why i am taking here means i want

            // Loop through the input array
            for (int i = 0; i < numbers.Length; i++)
            {
                // If-else condition to check if the number is even or odd
                if (numbers[i] % 2 == 0)
                {
                    results[i] = $"{numbers[i]} is Even";
                }
                else
                {
                    results[i] = $"{numbers[i]} is Odd";
                }
            }

            // Return the string array
            return results;
        }

        static void Main(string[] args)
        {
            // Input array
            int[] numbers = { 10, 15, 20, 25, 30 };  //
            //int[] numbers1 = new int[5] { 10, 15, 20, 25, 30 };  //


            // So that i am expecting that
            //
            // 10 is even
            // 15 is odd
            // 20 is even
            // 25 is odd
            // 30 is even
            //
            // is like that...


            // Call the method and get the result
            string[] output = ProcessArray(numbers);

            // Print the result
            Console.WriteLine("Output:");
            foreach (string result in output)
            {
                Console.WriteLine(result);
            }
        }
    }
}


#region Explanation

/*
 * 
 * Explanation:
Method ProcessArray:
-----------------------
-Takes an integer array as input (int[] numbers).
-Creates a string array results of the same size as the input array to store the output.
-Loops through the array using a for loop.
-Uses an if-else condition to check if the current number is even or odd.
-Stores the result in the results array.


Main Method:
------------------
-Defines an input array of integers.
-Calls the ProcessArray method with the input array.
-Outputs the results by iterating over the returned string array.
 * 
 */
#endregion
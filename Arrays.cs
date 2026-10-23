

using System;
using System.Collections;
/// <summary>
/// Array in C# is collection of elements of the same data type,
/// 
/// Example set of integer values is int array
///         set of string  values is string array
/// </summary>

class Arrays
{
    static void Main()
    {
        // 1. Creating set of integer values is int array with fixed size.
        int[] numbersGroup = new int[2]; 
        numbersGroup[0] = 100;
        numbersGroup[1] = 200;
        Console.WriteLine($"Numbers Group is {numbersGroup} "); //returns the grouptype here. i.e. int[]
                                                                //int and Int32 are exactly the same in C#, just different in naming.

        Console.WriteLine($"0th index of the numbersGroup {numbersGroup[0]}");
        Console.WriteLine($"1st index of the numbersGroup {numbersGroup[1]}");

        //numbersGroup[2] = 3; // you will receive the index out of range exception.
        //numbersGroup[3] = 4;

        //Here just cover the build solution so that you can see the errors in errorList window.

        //while compile time error if you try to force the debug also you will see build errors.
        //Before run the program if you find the any error thats called compile time error.
        //After run the program if you find the any error thats called run time error



        //2. you can Initializing an Array without fixed size:
        int[] numbersContainers_2 = new int[] { 1, 2, 3, 4, 5 , 6};
        numbersContainers_2[0] = 111;
        numbersContainers_2[50] = 111;
        Console.WriteLine(numbersContainers_2[50]);


        //3.Accessing Array Elements
        int value = numbersContainers_2[1];


        // The way of declaring the integer values without fixed size
        //                 0    1  2   3   4
        int[] numbers3 = { 10, 20, 30, 40, 50 };
        int  thirdNumber = numbers3[2]; // Accessing the third element (30)

        //4.Iterating Through an Array:
        // foreach is a keyword in csharp for supports the looping system which can useful for print the each value from the Array
        // foreach mean take everyvalue from the list
//        foreach (datatype | var variableName in CollectionName)
//{
//            // Code to execute for each element
//        }


        int[] CurrencyNotes = { 20, 100 ,500 };
        foreach (int currencyNote in CurrencyNotes)
        {
            Console.WriteLine($"Prining Every Currency Note i.e. : {currencyNote}");
        }

        //Want to increase every value while iterating
        //Debug the code while iterating so that you can understand the foreach.
        foreach (int currencyNote in CurrencyNotes)
        {
            int addCoin = 5;
            int updatedCurrencyNote = currencyNote + addCoin;
            Console.WriteLine($"Printng Every update Currency Note is : {updatedCurrencyNote}");
        }


        // and  we are having the differnt looping systems in csharp.net like foreach those are for , while and dowhile 


        //5. Getting Array Length:
        // string Array

        string[] books = { "MathMatics", "Physics", "Chemistry" };
        int booksLength = books.Length; // Length is 3//length is property in a string
        Console.WriteLine(booksLength);
        

        //6. Modifying Array Elements:
        int[] EmpIDs = { 101, 102, 103, 104, 105 };
        Console.WriteLine("Before update {0} " , EmpIDs);
        EmpIDs[2] = 99; // Changing the third element to 99
        Console.WriteLine("After update {0} ", EmpIDs);


        int[] numbers = { 1, 2, 3, 4, 5 };


        foreach (int number in numbers)
        {
            //Code to be executed
        }


        //func delegate and extension method

    }
    //int[] Arrays = new int[2,3,4,5,6,4];


}
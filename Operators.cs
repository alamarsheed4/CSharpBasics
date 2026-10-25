using System;

namespace MyCSharpApp{

    internal class Operators{

        // Arithmetic Operators
// + : Adds two operands. Example: 5 + 3 results in 8.
// - : Subtracts the second operand from the first. Example: 10 - 4 results in 6.
// * : Multiplies two operands. Example: 3 * 4 results in 12.
// / : Divides the first operand by the second. Example: 10.0 / 3.0 results in approximately 3.3333.
// % : Returns the remainder of a division operation. Example: 10 % 3 results in 1.


    static void Main(){

          //Arithmetic Operators:  + , - , * , / , %(numeric datatypes)

        // Any numeric datatype is OK...
        int sum = 5 + 3; // sum is 8

        int difference = 10 - 4; // difference is 6

        int productsLength = 3 * 4; // product is 12

        double result = 10.0 / 3.0; // result is 3.3333...

        int remainder = 10 % 3; // remainder is 1

        Console.WriteLine("****Arthamatic operators are useful for calculations the values****");
        Console.WriteLine($"Sum is {sum} , Difference is {difference} , productsLength is {productsLength}  , result is {result} , remainder is {remainder}");


        //string str =  "C#" + ".Net"; // (Its not recommanded)
        //string str1 = string.Concat("C#", ".Net");

        // Comparison Operators
        // == : Checks if two operands are equal. Example: 5 == 5 results in true.
        // != : Checks if two operands are not equal. Example: 5 != 3 results in true.
        // > : Checks if the first operand is greater than the second. Example: 8 > 5 results in true.
        // < : Checks if the first operand is less than the second. Example: 3 < 7 results in true.
        // >= : Checks if the first operand is greater than or equal to the second. Example: 8 >= 8 results in true.
        // <= : Checks if the first operand is less than or equal to the second. Example: 3 <= 7 results in true.


         //Comparison Operators:  == , != , > , < , >= , <=
        //== , != , > , >= , <=


        
        bool x = true;
        bool y = false;

        bool isEqual = (5 == 5); // isEqual is true

        bool isNotEqual = (5 != 3); // isNotEqual is true

        bool isGreater = (8 > 5); // isGreater is true

        bool isLess = (3 < 7); // isLess is true

        bool isGreaterOrEqual = (8 >= 8); // isGreaterOrEqual is true

        bool isLessOrEqual = (3 <= 7); // isLessOrEqual is true


        Console.WriteLine("****Compare operators are useful for Compare the values****");
        Console.WriteLine($"isEqual is {isEqual} , isNotEqual is {isNotEqual} , isGreater is {isGreater}  , isLess is {isLess} , isGreaterOrEqual is {isGreaterOrEqual} isLessOrEqual {isLessOrEqual}");


        string userName = "John";  // 4 charcters
        int lengthOfUserName = 4;
        bool isUserNameLengthCorrect = userName.Length == lengthOfUserName;
        Console.WriteLine($"isUserNameLengthCorrect - {isUserNameLengthCorrect}");


        //string isUserNameIsJohn = 


        string[] currencyItems = { "10$" , "20$" , "30$" };
        int noOfCurrencyNotes = 8;

        bool isCurrencyNotesEqual =   currencyItems.Length == noOfCurrencyNotes;
        Console.WriteLine($"isCurrencyNotesEqual - {isCurrencyNotesEqual}");

        //Logical Operators:  && , || , !

        // Logical Operators
// && : Returns true if both operands are true. Example: true && true results in true.
// || : Returns true if at least one of the operands is true. Example: true || false results in true.
// ! : Inverts the boolean value. Example: !true results in false.

        Console.WriteLine("***************** && (And) operator****************");
        bool checkResult1 = (true && true); // bothTrue is true
        Console.WriteLine($"Check value1 is {checkResult1}");

        bool checkResult2 = (5 == 5 && 5 != 3); // true and true
        Console.WriteLine($"chec" +
            $"kValues2 value is {checkResult2}");


        bool checkResult3 = (5 == 5 && 5 == 3); // true and false is false
        Console.WriteLine($"checkValues3 value is {checkResult3}");


        bool checkResult4 = (5 == 3 && 5 == 5); // false and true is false
        Console.WriteLine($"checkValues4 value is {checkResult4}");

        bool checkResult5 = (5 == 3 && 5 == 4); // false and false is false
        Console.WriteLine($"checkResult5 value is {checkResult5}");



        Console.WriteLine("*****************||(Or) operator****************");

        bool eitherTrue1 = (true || false); // True or false is true

        bool checkValues2 = ((5 == 5) || (5 == 3));

        bool checkValues3 = ((8 > 5) || (1 > 2));

        bool eitherTrue2 = (true || false); // eitherTrue is true

        bool notTrue = !true; // notTrue is false

        bool notFalse = !true; // notTrue is false

        // Nullable Types
// int? : An integer that can also be null. Example: int? nullableAge = null;
// bool? : A boolean that can also be null. Example: bool? nullableBool = null;
//  *  
//  * Operand : In programming, an operand is a term used to describe the objects that are manipulated by operators. 
//  * In other words, operands are the values or variables on which operators act.
//  *  Ex : 3 + 5 and + is a operator

// */

         /* Nullable types
         * 
         * By default value types cannot be null, but you can use nullable types to represent null values.
         * if you want to use nullbal types then you have to use ? after the datatype
           A nullable type is a value type that can also have a value of null

         Note :  By default int value is 0 so here if you want to make it as null then you have to use convert into nullable type
        */

        int age = 30;  // Value type  

        //null Means Novalue. Generally we apply the null value to Referecen types in C#.net . Example string str = null;

        int? nullableAge = null;

        int? age1 = 30;

        bool? nullableBool = null;

        bool? nullableBool1 = false;

        bool? status = true;

    }

}

}
//Note: Remember all Operators as We have to use in conditional statements, loops, and other programming constructs.

    

    

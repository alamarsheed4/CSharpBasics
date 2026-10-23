using System;
using System.Xml;

/*
 * When converting one type to another, think carefully about what you need to do.
 * Focus on your goal.
 *
 * Keep in mind that while you can convert Dollars to Indian Rupees or Indian Rupees to Dollars, you cannot convert Dollars to Human beings or Human beings to Dollars.
 */

/*
 *  Data type conversions
 * 
 *  Process of converting one datatype to another datatype
 *  
 *  Ex: string to int or
 *      int to string like that..
 * 
 * 
 * Data type conversions are two types 
 *   1. Implicit type conversion.
 *   2. Explicit type conversion.
 */

class DatatypeConversions
{
    static void Main()
    {
        /*
        Implicit Type Conversion (Type Promotion)
        It occurs when you convert a smaller data type into a larger data type without the risk of losing data.

        Datatype    Maximum value  
        Integral Types (Whole Numbers Only)
        byte        0 to 255
        int         ±2,147,483,648 or -2,147,483,648 to +2,147,483,647
        uint        0 to 4,294,967,295  
        long        -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807  
        ulong       0 to 18,446,744,073,709,551,615  

        Floating-Point Types (Fractional Values Allowed)
        decimal     ±79,228,162,514,264,337,593,543,950,335  
        float       ±3.40282347E+38F  
        double      ±1.7976931348623157E+308 
        */

        byte smallNumber = 5;
        int largeNumber = smallNumber; // Implicit conversion from byte to int  
        Console.WriteLine(largeNumber);

        /*
        Explicit Type Conversion (Type Casting):
        It occurs when you convert a larger data type into a smaller data type.
        This can result in data loss or truncation if the value doesn't fit within the target type's range.
        */

        int NoOfEmployees = 400; // 1.45 billian
        byte ConvertingNoOfEmployees = (byte)NoOfEmployees; // Explicit conversion from uint to int (data may be lost) 
        Console.WriteLine(ConvertingNoOfEmployees); // ouput is 44 due to binary wrapping of system



        double doubleValue = 10.75; 
        int intValue = (int)doubleValue; // Explicit conversion from double to int (data may be lost) . here decimal part is removed.
        Console.WriteLine(intValue);

        /*
        Converting to and from Strings:
        You often need to convert data to and from strings for input/output, parsing, and formatting.
        You can use methods like ToString(), int.Parse(), double.Parse(), and the Convert class for conversions.
        */

        int number = 42;
        string strNumber = number.ToString(); // Convert int to string
        Console.WriteLine("Str number is {0}", strNumber);

        // Convert string to int
        int parsedNumber = int.Parse(strNumber); // Convert string to int
        Console.WriteLine(parsedNumber);

        /*
        Type Conversion Methods:
        C# provides methods for converting between data types. For example, Convert.ToInt32(), int.Parse(),
        and int.TryParse() for converting to integers.
        */

        string strNum = "123";
        int num = Convert.ToInt32(strNum); // Converts a string to an int
        Console.WriteLine(num);

        /*
        Nullable Input Handling:
        int.Parse(): Does not accept null as input. It must be used with a non-null string.
        Convert.ToInt32(): Accepts null as input and returns 0 in such cases.
        */
        string nullableString = null ?? string.Empty;
        // int output = int.Parse(nullableString); // This will throw an exception
        int output1 = Convert.ToInt32(nullableString); // This will return 0
        Console.WriteLine(output1);

        var startTime = DateTime.Now;
        Console.WriteLine("StartTime is {0}", startTime.ToString());

        /*
        Boxing and Unboxing:
        Boxing is the process of converting a value type to a reference type (e.g., object).
        Unboxing is the reverse process, converting a boxed value back to its original value type.

        Value type: Data stored directly in memory
        Reference type: Reference to data stored in memory
        */

        int a = 10;   // a directly contains the data (10)
        string b = "Csharp"; // b holds a reference to this string ("Csharp") in memory.

        int num1 = 42;  // Directly assign the value into num1
        object obj = num1;   // Boxing: here object creates the reference for storing the num1 data
        
        Console.WriteLine($"Value of a {a}");
        Console.WriteLine($"Value of a {b}");
        
        Console.WriteLine($"Object value is : {obj}");

        int num2 = (int)obj; // Unboxing : Here we are converting the reference type to value type . here ref type stored in obj variable.
        Console.WriteLine($"num2 is : {num2}");

        Console.ReadLine();
    }
}
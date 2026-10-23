using System;

namespace MyCSharpApp
{
    internal class Datatypes
    {
        static void Main(string[] args)
        {
            int age = 25;
            string name = "Arsheed";
            byte data = 255; //byte max value can be 255 and min value is 0

            Console.WriteLine(name);
            Console.WriteLine(age);
            Console.WriteLine(data);

            //short Datatypes

            /*
            Range is : -32,768 to 32, 767
            Purpose : Stores small positive integers
            */
            short temperature = 20;
            Console.WriteLine("Temperature is" + temperature);

            short value1 = 32767;
            short value2 = -32768;

            Console.WriteLine("Value 1 " + value1);
            Console.WriteLine("Value 2 " + value2);
        

/* Datatypes in Csharp
Numeric Data Types: byte, short, ushort, int, uint, long, ulong, float, decimal, double
------------------
byte    : Represents unsigned integers ranging from 0 to 255.
short   : Represents signed integers ranging from -32,768 to 32,767.
ushort  : Represents unsigned integers ranging from 0 to 65,535.
int     : Represents signed integers ranging from -2,147,483,648 to 2,147,483,647.
uint    : Represents unsigned integers ranging from 0 to 4,294,967,295.
long    : Represents signed integers ranging from -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807.
ulong   : Represents unsigned integers ranging from 0 to 18,446,744,073,709,551,615.

Floating-Point Types (Fractional Values Allowed)
decimal : ±79,228,162,514,264,337,593,543,950,335
float   : ±3.40282347E+38F
double  : ±1.7976931348623157E+308

Boolean Data Type:
--------------------
bool    : Represents Boolean values true or false.

Character Data Types:
--------------------
char    : Represents a single Unicode character.

String Data Type:
------------------
string  : Represents a sequence of characters.

Other Data Types:
------------------
object  : Represents any type of object. // we will discuss in typecasting, boxing, and unboxing topics
dynamic : Represents a dynamic data type that can change at runtime.
void: Represents the absence of a type, commonly used for methods that do not return a value.
*/


        byte age1 = 25;  // No decimals, small positive number . Range 0 to 255 , Purpose  : Stores small unsigned integers
        Console.WriteLine("Byte Value: " + age1);

       
        /*
         * Range: -32,768 to 32,767
           Purpose: Stores small signed integers
         */
        short temperature1 = -1500;  // Handles small negative and positive values
        Console.WriteLine("Short Value: " + temperature1);


        /*ushort
         * Range: 0 to 65,535
         * Purpose: Stores small positive integers
         */
        ushort population = 50000;
        Console.WriteLine("UShort Value: " + population);


        /*int
           Range: -2,147,483,648 to 2,147,483,647
           Purpose: Default data type for integers
         */
        int salary = 100000;
        Console.WriteLine("Int Value: " + salary);


        /*unit
           Range: 0 to 4,294,967,295
           Purpose: Stores positive whole numbers only
         */
        uint distance = 3000000000U;
        Console.WriteLine("UInt Value: " + distance);


        /*
         * long
             Range: -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807
             Purpose: Used for very large or small integers
         */

        long worldPopulation = 7800000000; //or 7800000000L
        Console.WriteLine("Long Value: " + worldPopulation);


        /*ulong
            Range: 0 to 18,446,744,073,709,551,615
            Purpose: Large positive integers
        */
        ulong bankBalance = 100000000000000; // or 100000000000000UL;
        Console.WriteLine("ULong Value: " + bankBalance);


         /*******************Category: Floating - Point Numeric Data Types************************/
        /*decimal
              Range: 1.0 * 10^-28 to 7.9 * 10^28
              1.0 * 10^-28 Means 1.0*10^(-28) (10 to the power of -28)
              7.9 * 10^28 Means 7.9*10^28 (10 to the power of 28)
              Purpose: Precise calculations for money or financial transactions
         */

        decimal price = 199.99m; // Here m means decimal value if m is not their then that value is considered as double
        Console.WriteLine("Decimal Value: " + price);


        /*float
          Range: ±1.5 × 10⁻⁴⁵ to ±3.4 × 10³⁸ // Means From -3.40282347E+38 to 3.40282347E+38

          // -3.40282347E+38 means -3.40282347*10^38 (10 to the power of 38)
          // 3.40282347E+38  means  3.40282347*10^38 (10 to the power of 38)
          Purpose: Single-precision floating point
        */
        float pi = 3.14159f; // Here f means float value if f is not their then that value is considered as double
        Console.WriteLine("Float Value: " + pi);



        /*double
           Range: ±5.0 × 10⁻³²⁴ to ±1.7 × 10³⁰⁸  // This means it can store values as small as 5.0 * 10^(-324)  and as large as 1.7 * 10^(308).
           - 10⁻³²⁴ means 10 raised to the power of -324 (very small number).
           - 10³⁰⁸ means 10 raised to the power of 308 (very large number).
           Purpose: Double-precision floating point (default for fractional values)
        */

        double stockPrice = 987.65d; // Stock price in currency
        Console.WriteLine("Current Stock Price: $" + stockPrice);


        // Display the maximum and minimum values of various numeric data types
        Console.WriteLine("byte MaxValue: " + byte.MaxValue);
        Console.WriteLine("byte MinValue: " + byte.MinValue);

        // Display the maximum and minimum values using string interpolation
        Console.WriteLine($"byte datatype MaxValue: {byte.MaxValue} and MinValue: {byte.MinValue}");
        Console.WriteLine($"short datatype MaxValue: {short.MaxValue} and MinValue: {short.MinValue}");
        Console.WriteLine($"ushort datatype MaxValue: {ushort.MaxValue} and MinValue: {ushort.MinValue}");
        Console.WriteLine($"uint datatype MaxValue: {uint.MaxValue} and MinValue: {uint.MinValue}");
        Console.WriteLine($"ulong datatype MaxValue: {ulong.MaxValue} and MinValue: {ulong.MinValue}");
        Console.WriteLine($"float datatype MaxValue: {float.MaxValue} and MinValue: {float.MinValue}"); // 3.402823E+38 means 3.402823*10^38 (10 to the power of 38)
        Console.WriteLine($"decimal datatype MaxValue: {decimal.MaxValue} and MinValue: {decimal.MinValue}");
        Console.WriteLine($"double datatype MaxValue: {double.MaxValue} and MinValue: {double.MinValue}"); // double has a greater range than int
        Console.WriteLine($"int datatype MaxValue: {int.MaxValue} and MinValue: {int.MinValue}");
        Console.WriteLine($"long datatype MaxValue: {long.MaxValue} and MinValue: {long.MinValue}");

        // Define and display boolean, char, and string values
        bool boolValue = true;
        char charValue = 'A';
        string stringValue = "Hello, World!";

        Console.WriteLine("Boolean: " + boolValue);
        Console.WriteLine("Character: " + charValue);
        Console.WriteLine("String: " + stringValue);

        // Wait for user input before closing the console window
        Console.ReadLine();
    }
}
}     

    

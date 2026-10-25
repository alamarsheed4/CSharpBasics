using System;

namespace CsharpCourse_Intro
{

    /* 1.Defination : In C#, var is a keyword used for implicitly typing variables. Instead of explicitly specifying the variable type (like int, string, or double), you let the compiler automatically determines the data type based on the assigned value.
     * 
     * In programming, inference means automatically determining the type or value of something without explicit declaration. When we say "infer" in the context of variables, we mean that the compiler automatically figures out the type of the variable based on the value assigned to it.
     * 
     * 
     * Use cases :
     *    a.Type is inferred at compile time based on the right-hand side of the assignment.
     *    b.Cannot change type once the type is determined.
     *    c.The inferred type behaves exactly like if you had declared it explicitly.


    Note : Earlier you have created the values based on the explicit way
     */
    internal class VarDynamicExample
    {
        static void Main()
        {

            // Equivalent Explicit Declarations:
            int number = 10;      // Same as var number = 10;
            number = 20;
            string name = "Madan"; // Same as var name = "Madan";
            name = "C#.net";
            double price = 12.5;  // Same as var price = 12.5;
            price = 12.555;

            Console.WriteLine("Number Datatype is "+number.GetType());  // Output: System.Int32
            Console.WriteLine("Name DataType is "+name.GetType());    // Output: System.String
            Console.WriteLine(price.GetType());   // Output: System.Double


            var v_number = 10;           // Compiler infers the type as int
            var v_name = "Madan";        // Compiler infers the type as string Here 'Madan' is a string
            //v_name = 10;               // Error : Cannot implicitly convert type 'int' to 'string'
            var v_price = 12.5;          // Compiler infers the type as double

            Console.WriteLine(v_number.GetType());  // Output: System.Int32
            Console.WriteLine(v_name.GetType());    // Output: System.String
            Console.WriteLine(v_price.GetType());   // Output: System.Double


            int v_nameLength = v_name.Length; // by using var you are getting intellisence.


            /* Dynamic : 
             * 
             * 1. In C#, dynamic is a keyword used for dynamically-typed variables. It tells the compiler to defer the type checking to runtime.
             * This means that the type of a dynamic variable can change at runtime.
             * 2. Requires initialization: You can declare a dynamic variable without initialization.
             * 3. Can change type: The type of a dynamic variable can change at runtime.
             * 4. No IntelliSense: Since the type is determined at runtime, you won't get IntelliSense support for dynamic variables.
             * 
             */



            // Declaring a dynamic variable without initialization
            dynamic test ="Testing";

            

            dynamic d_number = 10;            // Compiler infers the type as int
            dynamic d_name = "Madan";        // Compiler infers the type as string
            //d_name = 10; // No Error : Can change the type at runtime but you will get the runtime error.
            dynamic d_price = 12.5;          // Compiler infers the type as double

            Console.WriteLine(d_number.GetType());  // Output: System.Int32
            Console.WriteLine(d_name.GetType());    // Output: System.String
            Console.WriteLine(d_price.GetType());   // Output: System.Double
            Console.WriteLine(test.GetType());

            int d_nameLength = d_number.ToString().Length;  // by using dynamic you are not getting intellisence.

        }
    }
}


/*
  KeyPoints :
-------------

About Var : 
    1. Generally we use var key word when we are working in anonymous data
    2. Requires initialization: You must initialize the variable when using var.
    3. Cannot change type: Once the compiler automatically determines what is the value that is , then we cannot change. other wise you will get the compile time error. Ex: if you say var number = 10 then always number takes the int type only here.

About Dynamic:
    1.Generally we use dynamic key word when we are working in anonymous data
    2.Requires initialization: You No need to initialize the variable when using dynamic.
    3.Cannot change type: Once the compiler  automatically determines the type, it can  change. But you will receive runtime error.



*/
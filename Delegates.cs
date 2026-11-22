using System;


/* Delegate : 
 *   Delegate in Csharp is nothing but a functional pointer which contains the function reference.
 *   Usually we use delegates as a function reference parameter while we are calling the method.
 *   
 *   Delegate do't have any implementaion.
 * */

namespace DelegatesBasicsNamespace
{
    // Step 1: Declare a delegate for an operation on two numbers
    public delegate double Operation(double x, double y);

    // Step 2: Calculator class
    public class Calculator
    {
        // Step 3: Method that uses the delegate to perform an operation
        public double PerformOperation(double x, double y, Operation operation)
        {
            return operation(x, y); // Instead of calling method add i am asking operation to do the task
                                    // Here operation will be receive the task from the caller..
        }
    }

    class Program
    {
        // Step 4: Operation methods
        public static double Add(double x, double y)
        {
            return x + y;
        }

        public static double Subtract(double x, double y)
        {
            return x - y;
        }

        public static double Multiply(double x, double y)
        {
            return x * y;
        }

        static void Main()
        {
            // Step 5: Create an instance of the Calculator class
            Calculator calculator = new Calculator();

            // Step 6: Use the delegate to perform different operations
            double result1 = calculator.PerformOperation(5, 3, Add);
            double result2 = calculator.PerformOperation(8, 2, Subtract);
            double result3 = calculator.PerformOperation(4, 6, Multiply);

            // Step 7: Display results
            Console.WriteLine($"Addition result: {result1}");
            Console.WriteLine($"Subtraction result: {result2}");
            Console.WriteLine($"Multiplication result: {result3}");

            Console.ReadLine();
        }
    }
}

#region Explanation of the Delegates
//Explanation:
//==============
//Delegate Declaration(Operation): Declares a delegate that represents an operation on two double parameters and returns a double result.

//Calculator Class: Represents a simple calculator.

//Method (PerformOperation): Accepts two numbers and an Operation delegate, then uses the delegate to perform the operation.

//Operation Methods (Add, Subtract, Multiply): Define separate methods for addition, subtraction, and multiplication.

//Main Method: Creates an instance of the Calculator class.

//Use the Delegate: Uses the delegate to perform different operations by passing different operation methods.

//Display Results: Prints the results of different operations.
#endregion
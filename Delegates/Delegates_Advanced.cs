using System;

namespace DelegatesAdvanced1
{
    class Program
    {
        delegate int SquareDelegate(int x);
        delegate void PrintMessageDelegatge(int x);
        delegate bool IsValidDelegate(int x);

        static int Square(int x)
        {
            return x * x;
        }

        static void PrintValue(int value)
        {
            Console.WriteLine(value);
        }

        static bool isCurrectValue(int value)
        {
            if (value == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static void Main()
        {
            // Using a named method . Here i can assign the Square Method over here.
            SquareDelegate squareMethod1 = Square;
            Console.WriteLine("Using named method: " + squareMethod1(5));


            PrintMessageDelegatge squareMethod2 = PrintValue;
            squareMethod2(5);
            //Console.WriteLine("Using named method: " , squareMethod2(5));


            IsValidDelegate squareMethod3 = isCurrectValue;
            Console.WriteLine("Using named method: " + squareMethod3(5));


            // Using an anonymous method with delegate
            SquareDelegate squareAnonymous = delegate (int x)
            {
                return x * x;
            };

            //or you can simplify this method into another approach as well .i.e. Lambda
            // Lambda is nothing but the way of your showing the delegate method in simple manner called lambda

            //SquareDelegate squareAnonymous1 = (int x) =>
            //{
            //    return x * x;
            //};


            //int a = squareAnonymous(5);


            Console.WriteLine("Using anonymous method: " + squareAnonymous(5));

            PrintMessageDelegatge PrintMessageAnonymous = delegate (int x)
            {
                Console.WriteLine(x);
            };

            PrintMessageDelegatge PrintMessageAnonymous1 =  (int x) =>
            {
                Console.WriteLine(x);
            };


            PrintMessageAnonymous(5);
            //Console.WriteLine("Using anonymous method: " + PrintMessageAnonymous(5));

            IsValidDelegate isValidAnonymous = delegate (int x)
            {
                if (x == 10)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            };
            Console.WriteLine("Using anonymous method: " + isValidAnonymous(5));


            //Just below example once you explain about the func delegate method
            // Using lambda expression (a concise way to write anonymous methods)
            SquareDelegate squareLambda = x => x * x;
            Console.WriteLine("Using lambda expression: " + squareLambda(5));


            Console.ReadLine();
        }

    }
}


#region Explanation 

//In this example, the SquareDelegate is a delegate that represents a method that takes an integer and returns an integer. First, I use a named method Square with the delegate. Then, I use an anonymous method with the delegate keyword to define a method inline. 


//Finally, I use a lambda expression, which is a more concise way to represent anonymous methods.


#endregion
using System;

namespace Method_PreparationInshortWay
{
    class Demo
    {
        public static void PrintNumber()
        {
            Console.WriteLine($"Number is 10");
        }

        public static int Multiplication(int number)
        {
            return number * number;
        }
    }

    class Program
    {
       public static void Main()
        {
           var PrintNumber = ()=>{             //shortcut way to create method
            Console.WriteLine($"Number is 10");
            };

            //Demo.PrintNumber();

            PrintNumber();

           var Multiplication = (int number)=>
            {
                return number * number;
            };

           var result2 =  Multiplication(33);

           Console.WriteLine($"Result2: {result2}");

            var result1 = Demo.Multiplication(10);
            Console.WriteLine($"Result1: {result1}");
        }
    }
}
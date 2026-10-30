using System;

namespace GenericExample
{
    class Logger
    {
        public void Log<T>(T data)
        {
            Console.WriteLine($"Logging Data : {data}");
        }
    }

    class Program
    {
        static void Main()
        {
            Logger logger = new Logger();

            logger.Log<string>("User Registered");
            logger.Log<int>(500);
            logger.Log<DateTime>(DateTime.Now);
        }
    }
}


#region Explanation

//This example shows a generic logger that can log any type of data.
//Instead of writing separate methods for string, int, or date, one generic method handles all types.
//This improves reusability and avoids duplicate code.

#endregion 
using System;

namespace CsharpCourse_Array
{
    class ArrayExample
    {
        static void Main()
        {
            //Array means collections of values with same datatype
            //Array should be fixed size

            int[] number = new int[4]; // 4 values

            number[0] = 50;
            number[1] = 30;
            number[2] = 60;
            number[3] = 20;

           // number[4] = 50; Here Exception Occurs i.e IndexOutOfRange Exception

            // Console.WriteLine($"The first element: {number[0]}");
            // Console.WriteLine($"The Second element: {number[1]}");
            // Console.WriteLine($"The Third element: {number[2]}");
            // Console.WriteLine($"The Fourth element: {number[3]}");

            foreach(int num in  number){
                Console.WriteLine($"The Element is :{num}");

            }

            int index = number[3];

            Console.WriteLine(index);

            int index1 = Array.IndexOf(number, 20);

            Console.WriteLine($"Index1 value: {index1}");

            int index2 = Array.IndexOf(number, 40);

            Console.WriteLine($"Index2 value: {index2}");

            int index3 = Array.IndexOf(number, 50); //No Index for the value 50 so, output will be -1;

            Console.WriteLine($"Index3 value: {index3}");

            int[] destinationArray = new int[number.Length];

            Array.Sort(number);

            Console.WriteLine(string.Join(",",number));

            Array.Copy(number,destinationArray,number.Length);

        }
    }
}
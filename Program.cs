using System;

namespace EvenOdd
{

    class Program
    {
        public static void Main()
        {
            int[] array = { 21, 43, 22, 66, 32, 12 };

            List<int> EvenNumbers = new List<int>();
            List<int> OddNumbers = new List<int>();


            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    EvenNumbers.Add(array[i]);
                }
                else
                {
                    OddNumbers.Add(array[i]);
                }
            }
            Console.WriteLine("Even Numbers: " + string.Join(", ", EvenNumbers));
            Console.WriteLine("Odd Numbers: " + string.Join(", ", OddNumbers));

            Console.WriteLine("*************************Using For Each*******************************");

            foreach (int numbers in EvenNumbers)
            {
                Console.WriteLine($"Even Number: {numbers}");
            }
            foreach (int numbers in OddNumbers)
            {
                Console.WriteLine($"Odd Number: {numbers}");
            }
        }
    }
}
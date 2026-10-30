using System;

namespace ParamsParameter_Example
{
    class StudentMarks
    {
        public static void Main()
        {
            CalculateTotalMarks("Arsheed",80,90,88,60);
            CalculateTotalMarks("Rajat",80,90,88,60,77,89,90);
        }

        static void CalculateTotalMarks(string studentName, params int[] marks)
        {
            int total = 0;
            foreach(int mark in marks)
            {
                total = total + mark;
            }

            Console.WriteLine($"Student Name : {studentName}");
            Console.WriteLine($"Total Marks : {total}");
        }
    }
}
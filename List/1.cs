using System;
using System.Collections.Generic;

namespace CsharpCourse_List
{
    class List_Example
    {
        static void Main()
        {
            List<int> numbers = new List<int>();

            numbers.Add(10);
            numbers.Add(20);
            numbers.Add(30);
            numbers.Add(40);

            Console.WriteLine($"Size of numbers :{numbers.Count}");
            Console.WriteLine(string.Join(",",numbers));

            foreach(int num in numbers)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine("****************************************");
            numbers.Remove(20);
            Console.WriteLine($"Size of numbers :{numbers.Count}");

            Console.WriteLine("List of Elements");
            foreach(int num in numbers)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine("****************************************");
            //Type Safety
            List<string> names = new List<string>() { "Robert","BOB", "Charlie" };

            names.Add("Alice");
            names.Add("Arsheed");

            foreach(string name in names)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine("****************************************");
            //3. Buit-in Methods

            List<int> scores = new List<int>() {10,20,30,40};

            Console.WriteLine("List of Scores!!");

            foreach(int Score in scores)
            {
                Console.WriteLine(Score);
            }
            Console.WriteLine("****************************************");
            //scores[0] = 60;
            scores.Insert(1, 60);

            foreach(int Score in scores)
            {
                Console.WriteLine(Score);
            }
            Console.WriteLine("****************************************");
            //removing the )th index value. -- 10
            scores.RemoveAt(0);
            Console.WriteLine("\n After Removing the value i.e 10");
            foreach(int Score in scores)
            {
                Console.WriteLine(Score);
            }
            //Check wheather the element is exist or not
           bool Contains20 = scores.Contains(20);

           Console.WriteLine(Contains20);
            
        }
    }
}
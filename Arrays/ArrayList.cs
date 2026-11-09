using System;
using System.Collections;

namespace CsharpCourse_ArrayList
{
    class ArrayListExample
    {
        static void Main()
        {
            ArrayList numbers = new ArrayList();
            //1. Adding the elements dynamically
            numbers.Add(10);
            numbers.Add(20);
            numbers.Add(30);

            Console.WriteLine($"Size of ArrayList: {numbers.Count}");

            foreach(int num in numbers)
            {
                Console.WriteLine($"ArrayList Element is: {num}");
            }
            Console.WriteLine("**************************************");
            //2.Non-Generic Collection
            //Adding elements dynamically
            ArrayList items = new ArrayList();

            // Adding different data types
            items.Add(10); //Integers
            items.Add("Rohit"); //string
            items.Add(34.2); //Double

            foreach(var item in items){
                Console.WriteLine($"ArrayList Element: {item}");
                Console.WriteLine($"{item}- {item.GetType()}");
            }

            //Boxing and unboxing
             ArrayList lists = new ArrayList();
            //1. Adding the elements dynamically
            lists.Add(10); //0
            lists.Add(20); //1
            lists.Add(30); //2
            lists.Add("Hello");

            int firstvalue= (int)lists[0];
            int secondvalue= (int)lists[1];

            Console.WriteLine($"First Value: {firstvalue}");
            Console.WriteLine($"Second Value: {secondvalue}");

            string fouthvalue = (string)lists[3];


            //4. Internally Array-Based

            ArrayList numbers1 = new ArrayList(3); // Initial capacity of 3

            Console.WriteLine($"Initial Capacity : {numbers1.Capacity}");

            numbers1.Add(10);
            numbers1.Add(20);
            numbers1.Add(30);

            numbers1.Add(40);

            Console.WriteLine($"After Adding Capacity : {numbers1.Capacity}");

            //Note: Adding New value to ArrayList will double the capacity of ArrayList 
        }
    }
}
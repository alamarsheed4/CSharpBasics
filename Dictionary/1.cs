using System;
using System.Collections.Generic;

namespace CsharpCourse_Dictionary
{
    class Dictionary_Example
    {
       public static void Main()
       {
         Dictionary<int, string> myBook = new Dictionary<int, string>();

         myBook.Add(1, "introduction");
         myBook.Add(2, "Chapter 1");
         myBook.Add(3, "Chapter 2");
         myBook.Add(4, "Chapter 3");

         foreach(var book in myBook)
         {
            Console.WriteLine(book);

         }
        Console.WriteLine("**************************************");
         foreach(var book in myBook)
         {
            
            Console.WriteLine($"Item Key :{book.Key} , Item value:{book.Value} ");

         }
        Console.WriteLine("**************************************");

         Dictionary<string, int> studentGrades = new Dictionary<string, int>();

         studentGrades.Add("Alice", 40);
         studentGrades.Add("Robert", 50);
         studentGrades.Add("Sammy", 60);
         studentGrades.Add("Daniel", 70);
         studentGrades.Add("Carl", 80);
        Console.WriteLine("**************************************");

        //Accessing value using keys
         Console.WriteLine("Sammy grade: " + studentGrades["Sammy"]);

         foreach(var studentgrade in studentGrades)
         {
            Console.WriteLine(studentgrade.Key+ " Grade is : "+ studentgrade.Value);
         }

         bool isDavidAvailable =  studentGrades.ContainsKey("David");

         Console.WriteLine(isDavidAvailable);
        Console.WriteLine("**************************************");

         //Update or modify the value
         studentGrades["Carl"] = 99;

         foreach(var studentgrade in studentGrades)
         {
            Console.WriteLine(studentgrade.Key+ " Grade is : "+ studentgrade.Value);
         }
        Console.WriteLine("**************************************");
        //Remove the value
         studentGrades.Remove("Carl");

         foreach(var studentgrade in studentGrades)
         {
            Console.WriteLine(studentgrade.Key+ " Grade is : "+ studentgrade.Value);
         }
       }
    }
}
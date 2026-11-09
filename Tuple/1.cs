using System;
using System.Collections.Generic;

namespace CsharpCourse_TupleExample
{
    class TupleExample
    {
        static int getProductID()
        {
            return 101;
        }

        static string getProductName()
        {
            return "Wireless Mouse";
        }
        static double getProductPrice()
        {
            return 3432.21;
        }

        public static void Main()
        {
            int productID = getProductID();
            Console.WriteLine(productID);

            string productName = getProductName();
            Console.WriteLine(productName);

            double productPrice = getProductPrice();
            Console.WriteLine(productPrice);

            static(int Id, string name, double price)getProductDetails() //return tuple
            {
              return (101, "Computer", 129993.43); //tuple value
            }

            (int id, string name, double Price)= getProductDetails(); // Tuple Deconstruction

            Console.WriteLine($"productId : {productID}, productName : {productName}, productPrice : {productPrice}");

            //value type tuple following named fields
            (int uid, string uname, bool uActive) user = (50, "Alice", false);
            Console.WriteLine($"{user.uid},{user.uname},{user.uActive}");
        
            Tuple<int, string, bool> person2 = new Tuple<int, string, bool>(50, "Alice", false);

            Console.WriteLine($"Person ID : {person2.Item1}, Person Name : {person2.Item2}, Person Active: {person2.Item3}");
        
            var studentReport = ("John", 450, "A");
            Console.WriteLine($"Person Name : {studentReport.Item1}, Total Marks : {studentReport.Item2}, Grade : {studentReport.Item3}");
        
            Console.WriteLine($"Student Report type : {studentReport.GetType()}");
        
        var studentReport1 = (Name:"Robert", Marks:432, Grade:"B");
        Console.WriteLine($"Person Name : {studentReport1.Name}, Total Marks : {studentReport1.Marks}, Grade : {studentReport1.Grade}");
        
        
        }
    }
}

/*
Key Points:
    1.A Tuple in C# can hold multiple values in a single unit..
    2.The values inside can be of different types (e.g., int, string, bool)
    3.Fixed-size: The number of values in a Tuple is determined when it’s created.
    4.It’s commonly used to return multiple values from methods.
    5.Elements can be accessed using default names (Item1, Item2) or custom names
    6.They are useful for temporary data grouping without creating new classes.
    7.
*/
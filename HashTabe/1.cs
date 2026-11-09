using System;
using System.Collections;

namespace CsharpCourse_HashtableExample
{
    class HashTableExample
    {
        public static void Main()
        {
            Hashtable studentDetails = new Hashtable();
            studentDetails.Add("Name", "Alice");
            studentDetails.Add("Age", 25);
            studentDetails.Add("Location", "New York");
            studentDetails.Add("IsStudent", true);

            //retrieve and display data..
            //studentDetails["Name"]; //Alice

            Console.WriteLine("Name: " + studentDetails["Name"]);
            Console.WriteLine("Age: " + studentDetails["Age"]);
            Console.WriteLine("Location: " + studentDetails["Location"]);
            Console.WriteLine("IsStudent: " + studentDetails["IsStudent"]);

            Console.WriteLine("*************************************");

            foreach(DictionaryEntry item in studentDetails)
            {
                Console.WriteLine(item.Key+ ":"+ item.Value);
            }

            //2. Example
            Hashtable data = new Hashtable();

            // Add different types of keys and values
            data.Add("Madan", "+91-7204****64");    // String key, String value
            data.Add(101, "Employee ID 101");       // Integer key, String value
            data.Add("Salary", 50000);              // String key, Integer value
            data.Add("IsActive", true);             // String key, Boolean value
            data.Add("OtherIncome", 50000);         // String key , Integer value
            data.Add("IsAdmin", true);              // String key, Boolean value
            data.Add(true, "IsActive");             // Boolean key, String value

            // Retrieve and display data
            Console.WriteLine("Phone Number of Madan: " + data["Madan"]);
            Console.WriteLine("Employee Details: " + data[101]);
            Console.WriteLine("Salary: " + data["Salary"]);
            Console.WriteLine("Is Active: " + data["IsActive"]);
            Console.WriteLine("Other Income: " + data["OtherIncome"]);
            Console.WriteLine("Is Admin: " + data["IsAdmin"]);
            Console.WriteLine("Employee Name: " + data["EmployeeName"]);

            // Check for key existence
            if (data.ContainsKey("Salary"))
            {
                Console.WriteLine("Salary Exists: " + data["Salary"]);
            }


            //Adding duplicate key
            // Please watch the video on exception handling....
            try
            {
                data.Add("Madan", "+91-7204****64");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }


            // Remove an item
            data.Remove("IsActive");
            // Iterate through the Hashtable
            foreach (DictionaryEntry item in data)
            {
                Console.WriteLine(item.Key + " : " + item.Value);

            }



            // Modify an item
            data["Salary"] = 60000;
            foreach (DictionaryEntry item in data)
            {
                Console.WriteLine(item.Key + " : " + item.Value);
            }



            // Clear the Hashtable
            data.Clear();



        }
    }
}

/*

 Q) What is Hashtable in C#?
 A: A Hashtable is a collection of key-value pairs that maps keys to values. It is similar to a dictionary, but it is not type-safe

 *  1. A Hashtable is a collection of key-value pairs that maps keys to values.
 *  2. It is similar to a dictionary, but it is not type-safe.
 *  3. It is part of the System.Collections namespace
 *  4. The keys and values can be of any type.
 *  5. The keys must be unique in the Hashtable.
 *  6. The values can be duplicated.
 *  7. The Hashtable is not type-safe, so you need to cast the values when retrieving them.
 *  
 *  
 *  Key-Value Pair Storage: Keys are used to uniquely identify values.
Unordered: The elements in a Hashtable are not stored in any specific order.
Allows Different Data Types: Both keys and values are of type object, allowing flexibility.
Non-Generic: Hashtable is non-generic, unlike Dictionary<TKey, TValue>, meaning you can store mixed data types.
 * 
 */
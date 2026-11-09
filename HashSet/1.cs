using System;
using System.Collections;

namespace CsharpCourse_HashsetExample
{
    class HashSetExample
    {
        public static void Main()
        {
            HashSet<string> usernames = new HashSet<string>();  

            usernames.Add("Alice");
            usernames.Add("Bob");
            usernames.Add("Charlie");

            usernames.Add("Alice");  //duplicate value

            foreach(string username in usernames)
            {
                Console.WriteLine($"Admin Usernames: {username}");
            }

            //check the value is availble
            bool isAliceAvailable = usernames.Contains("Alice");

            Console.WriteLine(isAliceAvailable);
            //Remove
           usernames.Remove("Alice");

        bool isAliceAvailable1 = usernames.Contains("Alice");
        Console.WriteLine(isAliceAvailable1);

        }
    }
}
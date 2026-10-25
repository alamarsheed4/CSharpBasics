using System;

namespace MyCSharpApp
{
    internal class String
    {
    static void Main()
    {
        string strCourseName = "Csharp";

        string strCourseName2 = "\"Csharp\"";

        Console.WriteLine(strCourseName);
        Console.WriteLine(strCourseName2);

        string numberStrings = "One.\nTwo.\nThree";
        Console.WriteLine($"NumberStrings : {numberStrings}");

        string csharpCoursePath = "D:\\ConsoleApplication\\Csharp_intro";

        Console.WriteLine($"Csharp Course Path : {csharpCoursePath}");

        string name = "Alice";
        int age = 30;

        string message = $"Name is: {name} and Age is: {age}";

        Console.WriteLine(message);

          /* *************************More indeep in string  **********************/

        /*
            String interpolation :
        String interpolation in C# is a way to insert the value of variables directly into a string.
        It Allows you to create strings with embedded expressions and variables,making it easy to build dynamic strings.
        */


        string name1 = "Alice";
        int age1 = 30;
        string message1 = $"My name is {name1} and I am {age1} years  old.";

        Console.WriteLine(message1);


        /* string is class which contains the set of the members . 
         * For example if you take the familty
           1. Property(Describes about charcterstics like name , age ) member
           2. Method(is nothig but action like cooking , reading) member

           Property : used for data access 
           Method   : used for executes the tasks|actions followed by ()
           
           for more details press f12 on string..
         */


        //property is length
        string text = "This is a sample string.";
        //-Length: Gets the number of characters in the current string.
        int length = text.Length; // length is 24
        Console.WriteLine($"Length is {length}");



        /*
        String Case Conversion:
        You can change the case of a string to lowercase or uppercase using ToLower() and ToUpper() methods.
        */

        string input = "Hello World";
        string lowerCase = input.ToLower(); // lowerCase is "hello world"
        string upperCase = input.ToUpper(); // upperCase is "HELLO WORLD"
        Console.WriteLine(lowerCase);
        Console.WriteLine(upperCase);

        string cName = "       Csharp        ";
        string updatedCName = cName.Trim();
        Console.WriteLine("Trim spaces: "+cName);

         string cName1 = "********Csharp******";
        string RemoveStarsCName = cName1.Trim('*');
        Console.WriteLine("Trim Stars from both sides "+RemoveStarsCName);


        string cName2 = "********Csharp******";
        string removeStarsBeforeCName = cName2.TrimStart('*');
        Console.WriteLine(removeStarsBeforeCName);


        string cName3 = "********Csharp******";
        string removeStarsAfterCName = cName3.TrimEnd('*');
        Console.WriteLine(removeStarsBeforeCName);


        string cName4 = "Csharp";
        string padLeft_CName = cName4.PadLeft(10); // By default, PadLeft(10) adds 4 spaces to make the total length 10 characters.
        string padLeft_AddStars_CName = cName4.PadLeft(10,'*'); // Here padLeft_CName should contains 10 charctes only
        Console.WriteLine(padLeft_AddStars_CName);


        string cName5 = "Csharp";
        string padRight_AddStars_CName = cName5.PadRight(10, '*'); // Here padLeft_CName should contains 10 charctes only
        Console.WriteLine(padRight_AddStars_CName);

           /*String Comparison
        You can use the Equals method to compare two strings. In this case, we perform a case -insensitive comparison.
        */

        string password = "Hello1234";
        bool isCorrect = password.Equals("Secretpassword"); // isCorrect is true
        Console.WriteLine(isCorrect);

        string confirmPassword = "Hello1234";
        bool isContainsPassword = confirmPassword.Equals("Password"); // isCorrect is true
        Console.WriteLine(isContainsPassword);


        /*Substring:
        The Substring method extracts a portion of a string, starting at a specified index and taking a specified length.
        */

        string sentence = "The quick brown fox jumps over the lazy dog.";
        //observation : Taking 2 input parameter
        string substring = sentence.Substring(4, 5); // substring is "quick"
        Console.WriteLine(substring);
        
        /*
         String Splitting:
         The Split method divides a string into an array of substrings based on a specified delimiter (in this case, a comma).
         */

        string data = "apple,banana,cherry";
        string[] fruits = data.Split(','); // fruits is an array containing "apple," "banana," and "cherry"
        Console.WriteLine(fruits);

        foreach(string fruit in fruits ){
          Console.WriteLine(fruit);
        }

        
        /*
         * String Replace:
         * The Replace method replaces all occurrences of a specified substring with another substring.
         */

        string original = "The quick brown fox";
        string replaced = original.Replace("brown", "red"); // replaced is "The quick red fox"
        Console.WriteLine(replaced);

        /*
        String Format:
        The string.Format method creates formatted strings by replacing placeholders with provided values.
        */

        int quantity = 5;
        double price = 9.99; //"You purchased 5 items for 9.99";
        //In string format method generally we follow the String interpolation technique
        //// Using string.Format to format a string with placeholders
        string receipt = string.Format("You purchased {0} items for {1}.", quantity, quantity * price); // receipt is "You purchased 5 items for $49.95."
        Console.WriteLine(receipt);

        Console.ReadLine();

        

    }



   }
}

using System;


class MethodsWithParamsWithReturnTypes
{
    static void Main()
    {
        //getEmployeeDetails is called and return type is string
        string employeeDetails = getEmployeeDetails(10);

        //getEmpAgeByName is called and return type is int
        int employeeid = getEmpAgeByName("John");

        //printEmpName is called and return type is void
        printEmpName("John");

        //PrintEmpDetailsByNameandAge is called and return type is void
        PrintEmpDetailsByNameandAge("John", 46);

        //getEmpDetailsByNameandAge is called and return type is string
        string employeedetailsAlongwithAge = getEmpDetailsByNameandAge("John", 46);

        string[] empNames = getEmployeeNames();

        int empNamesCount = getEmployessNamesLengh(empNames);

        Console.ReadLine();
    }

    /// <summary>
    /// Method1 is called and return type is string
    /// </summary>
    /// <param name="number"></param>
    /// <returns></returns>
    static string getEmployeeDetails(int number)
    {
        string employeeDetails = $"Employee Name is John And his Id is {number}";
        return employeeDetails;
    }

    /// <summary>
    /// Method2 is called and return type is int
    /// </summary>
    /// <param name="name"></param>
    /// <returns></returns>
    static int getEmpAgeByName(string name)
    {
        Console.WriteLine($"Method2 is called and Name is {name}");
        int employeeID = 46;
        return employeeID;
    }


    /// <summary>
    /// Method3 is called and return type is void
    /// </summary>
    /// <param name="name"></param>
    static void printEmpName(string name)
    {
        Console.WriteLine($"Emp Name is {name}");
    }


    /// <summary>
    /// Method4 is called and return type is void
    /// </summary>
    /// <param name="name"></param>
    /// <param name="ID"></param>

    static void PrintEmpDetailsByNameandAge(string name, int age)
    {
        Console.WriteLine($"Method4 is called Name is  {name} and id is {age}");
    }


    /// <summary>
    /// Method5 is called and return type is string
    /// </summary>
    /// <param name="name"></param>
    /// <param name="age"></param>
    /// <returns></returns>

    static string getEmpDetailsByNameandAge(string name, int age)
    {
        return $"Method5 is called . Name is  {name} and id is {age}";
    }


    /// <summary>
    /// Method6 is called and return type is string[]
    /// </summary>
    /// <returns></returns>
    static string[] getEmployeeNames()
    {
        string[] names = { "John", "Doe" };
        return names;
    }

    /// <summary>
    /// Method7 is called and return type is int
    /// </summary>
    /// <param name="names"></param>
    /// <returns></returns>
    static int getEmployessNamesLengh(string[] names)
    {
        int length = names.Length;
        return length;
    }


    /// <summary>
    /// Method8 is called and return type is int[]
    /// </summary>
    /// <param name="numbers"></param>
    /// <returns></returns>
    static int[] method8(int[] numbers)
    {
        //update each number from numbers with +2
        for (int i = 0; i < numbers.Length; i++)
        {
            //numbers[i] = 10; first try this.
            numbers[i] = numbers[i] + 2;
        }

        return numbers;

    }


}
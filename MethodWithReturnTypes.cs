
using System;


class MethodsWithReturnTypes
{
    static void Main()
    {
        Method1();
        Method2();
        Method3();

        Console.ReadLine();
    }

    /// <summary>
    /// Method1 is called and return type is string
    /// </summary>
    /// <returns>string</returns>
    static string Method1()   //GetEmployeeName
    {
        string employeeName = "John";
        return employeeName;
    }


    /// <summary>
    /// Method2 is called and return type is int
    /// </summary>
    /// <returns>int</returns>
    static int Method2()   //GetEmployeeAge
    {
        int employeeAge = 35;
        return employeeAge;
    }


    /// <summary>
    /// Method3 is called and return type is void
    /// </summary>
    /// <returns>void</returns>
    static void Method3()  //Print Emp Details
    {
        Console.WriteLine("John is working in Microsoft and his Age is 35.");
    }
}


//Replace MEthods with properNames

using System;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Xml.Linq;


class MethodsWithParams
{
    static void Main()
    {
       
        Method1(10);
        Method2("John");

        //Method3(10);
        //Method3("John");
     
        Console.ReadLine();
    }

    /// <summary>
    /// Method1 is called and number is passed as parameter
    /// </summary>
    /// <param name="number"></param>
    static void Method1(int number)
    {
        Console.WriteLine($"Method1 is called and number is {number}");
    }

    /// <summary>
    /// Method2 is called and name is passed as parameter
    /// </summary>
    /// <param name="name"></param>
    static void Method2(string name)
    {
        

        Console.WriteLine($"Method2 is called and Name is {name}");
    }

    /// <summary>
    ///  Here we are passing the dynamic as a paramter so any  value we can pass over here. where as we cannot pass var keyword as a parameter
    /// </summary>
    /// <param name="dynamic"></param>
    static void Method3(dynamic dynamicValue)  // Here var key work you canot pass the parameter.
    {
        Console.WriteLine($"dynamic is called and Name is {dynamicValue}");
    }


}

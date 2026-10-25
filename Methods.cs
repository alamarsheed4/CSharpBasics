
using System;


class Methods
{
    ///  Method is a block which we are going to re-use that.
    /// <summary>
    ///  This is Main Method

    /// </summary>
    static void Main()
    {

        //Console.WriteLine("Method1 is called");
        //Console.WriteLine("Method2 is called");

        Method1();
        Method2();
       
        Console.ReadLine();
    }

    /*void method which shouldnot return any thing. rather than we are going to executes the statments */
    /// <summary>
    /// This is Method1
    /// </summary>
    static void Method1()
    {
        Console.WriteLine("Method1 is called");
    }


    /// <summary>
    /// This is Method2
    /// </summary>

    static void Method2()
    {
        Console.WriteLine("Method2 is called");
    }


    static void xyz()
    {
        Method1();
    }

    static void abc()
    {
        Method2();
    }


    static void CallMethodsOfProgram()
    {
        Method1();
        Method2();
    }



}

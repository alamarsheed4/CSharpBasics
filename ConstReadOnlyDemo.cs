using System;

class ConstReadonlyExample
{
    const double pi = 3.14;

    readonly string createDate = "12-Dec-2026";

    public ConstReadonlyExample(){
        this.createDate = "12-Mar-2025";

    }

    static void Main(){
       Console.WriteLine(ConstReadonlyExample.pi);

        ConstReadonlyExample file = new ConstReadonlyExample();

        Console.WriteLine($"Read only Value : {file.createDate}");

        

    }
}
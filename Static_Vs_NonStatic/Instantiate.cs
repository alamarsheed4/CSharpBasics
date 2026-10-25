using System;

namespace StaticVsNonStaticInstantiate{

    public static class Static_Class{

   static public void Message(){

        Console.WriteLine("This is Static Class");
    }
    }
    public class NonStatic_Class{

    public void Message(){

        Console.WriteLine("This is Non Static Class");
    }

    }

   class Program{

     static void Main(){

        Static_Class.Message();

        NonStatic_Class nonStatic_Class = new NonStatic_Class();

        nonStatic_Class.Message();
    }
   }
}
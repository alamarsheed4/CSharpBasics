using System;
using projectA;

namespace ProjectB
{
    class ClassY : ClassA
    {
        public void DisplayClassMembers()
        {
           Console.WriteLine("Inside Class Y (Non-Derived) :") ;
          // Console.WriteLine(privateVar); // X Not Accessible 

          ClassA classA = new ClassA();
          // Console.WriteLine(classA.privateVar); // X Not Accessible 
          Console.WriteLine(classA.protectedVar);
          //Console.WriteLine(classA.internalVar); // X Not Accessible 

          Console.WriteLine(classA.protectedInternalVar);
          Console.WriteLine(classA.publicVar);

        }
    }
}
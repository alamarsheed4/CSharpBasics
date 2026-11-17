using System;
using projectA;

namespace ProjectB
{
    class ClassX : ClassA
    {
        public void DisplayClassMembers()
        {
           Console.WriteLine("Inside Class X (Derived) :") ;
          // Console.WriteLine(privateVar); // X Not Accessible 
          Console.WriteLine(protectedVar);
         // Console.WriteLine(internalVar); // X Not Accessible
           Console.WriteLine(protectedInternalVar);
           Console.WriteLine(publicVar);
        }
    }
}

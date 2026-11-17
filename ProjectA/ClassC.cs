using System;

namespace projectA
{
    class ClassC
    {
        void DisplayClassCMember()
        {
            Console.WriteLine("Inside Class C ");

            ClassA classA = new ClassA();
            //Console.WriteLine(classA.privateVar); //X Not Accessible
            Console.WriteLine(classA.internalVar);
            Console.WriteLine(classA.protectedInternalVar);
            Console.WriteLine(classA.publicVar);
            
        }
    }
}
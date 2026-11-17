using projectA;

namespace projectB
{
    public class ClassB : ClassA
    {
        void DisplayDerivedClassMembers()
        {
            Console.WriteLine("Inside Class B(Derived) :");
            //Console.WriteLine(privateVar);
            Console.WriteLine(protectedVar);
            Console.WriteLine(internalVar);
            Console.WriteLine(protectedInternalVar);
            Console.WriteLine(publicVar);
            
        }
    }
}
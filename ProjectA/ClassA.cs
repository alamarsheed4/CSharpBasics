using System;

namespace projectA
{
    public class ClassA
    {
        private string privateVar = "Private: Only Accessible within the class";
        protected string protectedVar = "Protected: Only Accessible within the class and its derived classes";
        internal string internalVar = "Internal: Only Accessible within the same Assembly!!";
        protected internal string protectedInternalVar = "Protected Internal: Only Accessible within the same Assembly and derived class!!";
        public string publicVar = "public: Accessible within the same Assembly and another class!!";

        void DisplayBaseClassMembers()
        {
            Console.WriteLine("Inside Class A:");
            Console.WriteLine(privateVar);
            Console.WriteLine(protectedVar);
            Console.WriteLine(internalVar);
            Console.WriteLine(protectedInternalVar);
            Console.WriteLine(publicVar);
            

        }
        
    }
}

//Note: By default class have internal Access Modifiers
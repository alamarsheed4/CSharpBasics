using System;

namespace AbstractionSystem
{
    abstract class AbstractClassDemo
    {
        public AbstractClassDemo()
        {

        }

        public AbstractClassDemo(int eId)
        {

        }

        public abstract int age{ get; set;}

        public abstract string name{ get; set;}

        public string? location { get; set;}

        public abstract void Message();

        public abstract string Message1();

        public void getMessage()
        {
            Console.WriteLine("Simple Message");
        }
    
    }

}
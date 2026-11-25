using System;

namespace WithDIP
{
    // Abstraction
    interface IWorker
    {
        void DoWork();
    }

    // Concrete worker types
    class Employee : IWorker
    {
        public void DoWork()
        {
            Console.WriteLine("Employee is doing assigned work...");
        }
    }

    class Intern : IWorker
    {
        public void DoWork()
        {
            Console.WriteLine("Intern is learning and doing basic tasks...");
        }
    }

    class Contractor : IWorker
    {
        public void DoWork()
        {
            Console.WriteLine("Contractor is completing project-based work...");
        }
    }

    class Manager
    {
        private IWorker worker; // Depends on abstraction

        public Manager(IWorker worker)
        {
            this.worker = worker;
        }

        public void AssignWork()
        {
            Console.WriteLine("Manager assigning work...");
            worker.DoWork(); // Works with any type of worker
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Manager manager1 = new Manager(new Employee());
            manager1.AssignWork();

            Manager manager2 = new Manager(new Intern());
            manager2.AssignWork();

            Manager manager3 = new Manager(new Contractor());
            manager3.AssignWork();
        }
    }
}

/*
 Explanation:
 1. Manager depends on IWorker instead of Employee.
 2. Any worker type (Employee, Intern, Contractor) can be plugged in.
 3. Manager code never changes when new worker types are added.

 Advantages:
 - Fully follows DIP
 - High flexibility (easy to extend)
 - No modification needed in Manager class
 - Good for testing (mock workers)
*/
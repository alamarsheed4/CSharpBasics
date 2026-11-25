using System;

namespace WithoutDIP
{
    class Employee
    {
        public void DoWork()
        {
            Console.WriteLine("Employee is doing assigned work...");
        }
    }

    class Manager
    {
        // ❌ Hard-coded dependency on Employee
        private Employee employee = new Employee();

        public void AssignWork()
        {
            Console.WriteLine("Manager assigning work...");
            employee.DoWork(); // Always uses Employee class
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Manager manager = new Manager();
            manager.AssignWork();
        }
    }
}

/*
 Explanation:
 1. Manager depends directly on Employee (concrete class).
 2. If the company hires Interns, Contractors, or RemoteEmployees,
    Manager MUST be modified.
 3. This is a DIP violation.

 Problems:
 - Hard-coded dependency
 - Not flexible
 - Cannot extend without changing Manager class
 - Difficult to test
*/
using System;

namespace GenericWhereClassExample
{
    // Generic repository restricted to CLASS (reference types only)
    class Repository<T> where T : class
    {
        public void Save(T entity)
        {
            Console.WriteLine($"{typeof(T).Name} saved successfully");
        }
    }

    // Real-time entity
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    class Program
    {
        static void Main()
        {
            // Works: Employee is a class
            Repository<Employee> employeeRepo = new Repository<Employee>();
            employeeRepo.Save(new Employee { Id = 101, Name = "Ravi" });

            Repository<string> numberRepo = new Repository<string>();
            //Repository<bool> numberRepo1 = new Repository<bool>();
            // ❌ Not allowed (compile-time error)
            // Repository<int> numberRepo = new Repository<int>();
        }
    }
}


#region Explnation

//The where T : class constraint ensures that the generic type must be a reference type.
//This is commonly used in repositories and services that work with entities, not primitive values.
//It improves type safety and prevents invalid usage at compile time.

#endregion
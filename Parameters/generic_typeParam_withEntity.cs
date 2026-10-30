using System;

namespace GenericExample_WithEntity
{
    class Repository
    {
        public void Save<T>(T entity)
        {
            Console.WriteLine($"{typeof(T).Name} data saved successfully");
        }
    }

    class Employee
    {
        public int Id { get; set; }
    }

    class Student
    {
        public int Id { get; set; }
    }

    class Program
    {
        static void Main()
        {

            //var name = typeof(string).Name; 

            Repository repo = new Repository();
            //repo.Save<string>("Audit Log");
            //repo.Save<int>(1000);
            repo.Save<Employee>(new Employee { Id = 101 });
            repo.Save<Student>(new Student { Id = 101 });

            //NOw i want to only save the classes 

        }
    }
}
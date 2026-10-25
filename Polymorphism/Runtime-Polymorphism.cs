using System;

namespace EmployeeSalarySystemRuntime
{
    abstract class Employee
    {
         public string? Name{get; set;}
         public int hoursWorked{get; set;}
         public int hourlyRate{get; set;}
         public abstract double CalculateSalary();
         public void DisplayDetails()
         {
            Console.WriteLine($"Employee Name: {Name}");
            Console.WriteLine($"Hourly Worked: {hoursWorked}");
            Console.WriteLine($"Hourly Rate: {hourlyRate}");

         }
         
    }

    class PermanentEmployee : Employee
    {
        public override double CalculateSalary()
        {
             double baseSalary = hoursWorked * hourlyRate;
             double bonus = baseSalary * 0.10;

             return baseSalary + bonus;
        }
    }
    class ContractEmployee : Employee
    {
        public override double CalculateSalary()
        {
            double baseSalary = hoursWorked * hourlyRate;
            double deduction = baseSalary * 0.10;

            return baseSalary - deduction;
        }    

    }
    class Freelancer : Employee
    {
         public override double CalculateSalary()
        {
           
            return 983822.22;
        }    

    }

    class Program
    {
        public static void Main()
        {
            Console.WriteLine("*****************Parmanent Employee***************");
            Employee employee = new PermanentEmployee();
            employee.Name = "John";
            employee.hoursWorked = 108;
            employee.hourlyRate = 50;

            employee.DisplayDetails(); //this is not abstract method
            double salary =  employee.CalculateSalary(); //this is abstract method

            Console.WriteLine($"Parmanent Employee Salary: {salary}");
            
            Console.WriteLine("*****************Contract Employee***************");

            Employee employee1 = new ContractEmployee();
            employee1.Name = "Rajat";
            employee1.hoursWorked = 211;
            employee1.hourlyRate = 60;

            employee1.DisplayDetails(); //this is not abstract method
            double salary1 =  employee1.CalculateSalary(); //this is abstract method
            
            Console.WriteLine($"Contract Employee Salary: {salary1}");

            Console.WriteLine("*****************Freelancer Employee***************");

            Employee employee2 = new Freelancer();
            employee2.Name = "Sandeep";
            employee2.hoursWorked = 203;
            employee2.hourlyRate = 40;

            employee2.DisplayDetails(); //this is not abstract method
            double salary2 =  employee2.CalculateSalary(); //this is abstract method
            
            Console.WriteLine($"Freelancer Salary: {salary2}");
        }
    }
}
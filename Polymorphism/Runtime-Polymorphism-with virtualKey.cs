using System;

namespace EmployeeSalarySystemRuntime
{
    abstract class Employee
    {
         public string? Name{get; set;}
         public int hoursWorked{get; set;}
         public int hourlyRate{get; set;}
         public virtual double CalculateSalary()
         {
            return hoursWorked * hourlyRate;
         }
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
             double baseSalary = base.CalculateSalary();
             double bonus = baseSalary * 0.10;

             return baseSalary + bonus;
        }
    }
    class ContractEmployee : Employee
    {
        public override double CalculateSalary()
        {
            double baseSalary = base.CalculateSalary();
            double deduction = baseSalary * 0.10;

            return baseSalary - deduction;
        }    

    }
    class Freelancer : Employee
    {
         public override double CalculateSalary()
        {
           
            return base.CalculateSalary();
        }    

    }

    class Program
    {
        public static void Main()
        {
            Console.WriteLine("*****************Parmanent Employee***************");
            Employee employee = new PermanentEmployee();
            employee.Name = "Arsheed";
            employee.hoursWorked = 342;
            employee.hourlyRate = 20;

            employee.DisplayDetails(); //this is not abstract method
            double salary =  employee.CalculateSalary(); //this is abstract method

            Console.WriteLine($"Parmanent Employee Salary: {salary}");
            
            Console.WriteLine("*****************Contract Employee***************");

            Employee employee1 = new ContractEmployee();
            employee1.Name = "Sanjay";
            employee1.hoursWorked = 342;
            employee1.hourlyRate = 56;

            employee1.DisplayDetails(); //this is not abstract method
            double salary1 =  employee1.CalculateSalary(); //this is abstract method
            
            Console.WriteLine($"Contract Employee Salary: {salary1}");

            Console.WriteLine("*****************Freelancer Employee***************");

            Employee employee2 = new Freelancer();
            employee2.Name = "Raman";
            employee2.hoursWorked = 322;
            employee2.hourlyRate = 80;

            employee2.DisplayDetails(); //this is not abstract method
            double salary2 =  employee2.CalculateSalary(); //this is abstract method
            
            Console.WriteLine($"Freelancer Salary: {salary2}");
        }
    }
}
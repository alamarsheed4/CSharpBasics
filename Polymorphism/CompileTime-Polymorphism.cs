using System;

namespace  EmployeeSalarySystem
{
    public class EmployeeSalaryCalculation
    {
        public double CalculateSalary(double monthlySalary)
        {
            return monthlySalary;
        }
        
        //Hourly-based salaries employee - company Advocates
        public double CalculateSalary(int hoursWorked, int hourlyRate)
        {
            return hoursWorked*hourlyRate;
        }
        //sales-based salary - Marketing People
        public double CalculateSalary(double salesAmount, double commissionRate, bool isSales)
        {
            return salesAmount * commissionRate;
        }

        //Freelancer salary with bonus
        public double CalculateSalary(int  hoursWorked, int hourlyRate, double bonus)
        {
            return (hoursWorked*hourlyRate)*bonus;
        }

    }

    class Program{
        public static void Main()
        {
            EmployeeSalaryCalculation employeeSalaryCalculation = new EmployeeSalaryCalculation();

           double employee1 =  employeeSalaryCalculation.CalculateSalary(78000);
           double employee2 =  employeeSalaryCalculation.CalculateSalary(40, 20);
           double employee3 =  employeeSalaryCalculation.CalculateSalary(67000, 0.5 , true);
           double employee4 =  employeeSalaryCalculation.CalculateSalary(40, 30 , 5000);
        
           Console.WriteLine($"Fixed salary: {employee1}");
           Console.WriteLine($"Hourly Rate: {employee2}");
           Console.WriteLine($"Sales person salary: {employee3}");
           Console.WriteLine($"Freelancer's salary: {employee4}");
        }

    }
}
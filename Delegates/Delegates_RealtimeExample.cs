using DelegatesBasicsNamespace;
using System;
using System.Xml.Linq;

namespace DelegatesRealtimeNamespace
{

    // Step 1: Declare a delegate for calculating bonuses having the salary input parameter.
    public delegate double BonusCalculator(double salary);

    // Step 2: Employee class
    public class Employee
    {
        public string Name { get; set; }
        public double Salary { get; set; }

        // Step 3: Constructor
        public Employee(string name, double salary)
        {
            Name = name;
            Salary = salary;
        }

        // Step 4: Method that uses the delegate to calculate bonuses
        public double CalculateBonus(BonusCalculator bonusCalculator)
        {
            return bonusCalculator(Salary);
        }
    }

    class Program
    {
        // Step 5: Bonus calculation methods
        public static double StandardBonus(double salary)
        {
            // Standard bonus calculation: 5% of salary
            return salary * 0.05;
        }

        public static double HighPerformanceBonus(double salary)
        {
            // High-performance bonus calculation: 10% of salary
            return salary * 0.1;
        }

        static void Main()
        {
            // Step 6: Create instances of the Employee class
            Employee employee1 = new Employee("John Doe", 50000);
            Employee employee2 = new Employee("Jane Smith", 75000);

            // Step 7: Use the delegate to calculate bonuses for employees
            double bonus1 = employee1.CalculateBonus(StandardBonus);
            double bonus2 = employee2.CalculateBonus(HighPerformanceBonus);

            // Step 8: Display results
            Console.WriteLine($"{employee1.Name}'s Bonus: ${bonus1}");
            Console.WriteLine($"{employee2.Name}'s Bonus: ${bonus2}");

            Console.ReadLine();
        }
    }
}


#region Explanation of the Delegates
//Explanation:

//Delegate Declaration(BonusCalculator): Declares a delegate that represents a method accepting a double parameter (salary) and returning a double (bonus).

//Employee Class: Represents an employee with properties for name and salary.

//Constructor: Initializes an employee with a name and salary.

//CalculateBonus Method: Accepts a BonusCalculator delegate as a parameter, allowing different bonus calculation methods to be passed.

//Bonus Calculation Methods (StandardBonus, HighPerformanceBonus): Define separate methods for standard and high-performance bonus calculations.

//Main Method: Creates instances of the Employee class.

//Use the Delegate: Uses the delegate to calculate bonuses for different employees by passing different bonus calculation methods.

//Display Results: Prints the calculated bonuses for each employee
#endregion
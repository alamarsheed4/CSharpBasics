using System;

namespace ValueTypeParams{

    class Employee
    {
        public static void Main()
        {
            int empId = 101;
            bool isActive = false;
            string name = "Arsheed";

            Console.WriteLine("Outside Method!!");
            Console.WriteLine($"Employee Id: {empId}");
            Console.WriteLine($"Employee Active Staus: {isActive}");
            Console.WriteLine($"Employee Name: {name}");

            UpdateEmployeeDetails(empId, isActive, name);
        }
        public static void UpdateEmployeeDetails(int empId, bool isActive, string name)
        {
            empId = 102;
            isActive = true;
            name = "Ravi";

            Console.WriteLine("**********************************");
            
            Console.WriteLine("Inside Method!!");
            Console.WriteLine($"Employee Id: {empId}");
            Console.WriteLine($"Employee Active Staus: {isActive}");
            Console.WriteLine($"Employee Name: {name}");
        }
    }
}
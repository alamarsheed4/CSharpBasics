using System;

namespace InTypeParams
{
    class Employee
    {

        public static void Main()
        {
            int empId = 101;
            bool isActive = false;
            string name = "Arsheed";

            Console.WriteLine("After Method!!");
            Console.WriteLine($"Employee Id: {empId}");
            Console.WriteLine($"Employee Active Staus: {isActive}");
            Console.WriteLine($"Employee Name: {name}");

            UpdateEmployeeDetails(in empId,in isActive,in name);
        }
        public static void UpdateEmployeeDetails(in int empId,in bool isActive,in string name)
        {
            empId = 102;
            isActive = true;
            name = "Ravi";

            Console.WriteLine("**********************************");
            
            Console.WriteLine("Inside Method!!");
            Console.WriteLine($"Employee Id: {empId}");
            Console.WriteLine($"Employee Active Staus: {isActive}");
            Console.WriteLine($"Employee Name: {name}");

            //empId = 212;
        
        //Note: When we use "In" Type Parameter inside a method
        //      it becomes readonly parameter you cannot resassign
        //      inside methods
        }
    }
}
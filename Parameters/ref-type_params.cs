using System;

namespace refTypeParams
{
    class Employee
    {

        public static void Main()
        {
            // Employee details
            int employeeId = 101;
            bool isActive = false;
            string employeeName = "Arsheed";

             // Passing variables using ref keyword
            // Actual memory reference is passed to the method
            UpdateEmployeeDetails(ref employeeId,ref isActive,ref employeeName);

            // Values are modified because ref works on the same memory
            Console.WriteLine("OutSide Method!!");
            Console.WriteLine($"Employee Id: {employeeId}!!");
            Console.WriteLine($"Employee Active Staus: {isActive}!!");
            Console.WriteLine($"Employee Name: {employeeName}!!!");

        }
        public static void UpdateEmployeeDetails(ref int empId,ref bool status,ref string name)
        {
           
            Console.WriteLine("**********************************");

            empId = 321;
            status = true;
            name = "Sandeep";
            
            Console.WriteLine("Inside Method!!");
            Console.WriteLine($"Employee Id: {empId}");
            Console.WriteLine($"Employee Active Staus: {status}");
            Console.WriteLine($"Employee Name: {name}");       
        
        }
    }
}

#region Explnation
//In this example, the ref keyword is used to pass parameters by reference instead of by value.
//When we use ref, the method receives the actual memory location of the variable, not a copy.
//Because of this, any changes made inside the method are reflected back in the Main method.

//The ref parameter must be initialized before passing to the method, and both the method call and method definition must use the ref keyword.
//This approach is commonly used when we want a method to update existing data, such as updating employee details, counters, or configuration values.
#endregion
using System;

namespace TypeParameter_OutTYpes
{
    class Employee{
        
        static void Main()
        {
            int employeeId = 101;    //you dont need to initialize the value if you want
            bool isActive = false;
            string employeeName = "Chandra";

            UpdateEmployeeDetails(out employeeId, out isActive, out employeeName);

            Console.WriteLine("Outside the method call");
            Console.WriteLine($"Employee Id :  {employeeId}");
            Console.WriteLine($"Is Active : {isActive}");
            Console.WriteLine($"Employee Name : {employeeName}");
        }

        static void UpdateEmployeeDetails(out int empId,out bool status,out string name)
        {
            empId = 104;
            status = true;
            name = "Ravi";

            Console.WriteLine("Inside Method!!!");
            Console.WriteLine($"Employee Id : {empId}");
            Console.WriteLine($"Employee Id : {status}");
            Console.WriteLine($"Employee Id : {name}");
        }

    }
}
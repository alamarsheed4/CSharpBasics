using System;

namespace diff_ref_out_params
{
    class EmployeeDemo{
        
        static void Main()
        {
            Console.WriteLine("===== REF EXAMPLE =====");
            int employeeIdref = 101;  
            bool isActiveref = false;
            string employeeNameref = "Chandra";

            UpdateEmployeeUsingRef(ref employeeIdref, ref isActiveref, ref employeeNameref);

            Console.WriteLine("After ref method call");
            Console.WriteLine($"Employee Id :  {employeeIdref}");
            Console.WriteLine($"Is Active : {isActiveref}");
            Console.WriteLine($"Employee Name : {employeeNameref}");

            Console.WriteLine("\n===== OUT EXAMPLE =====");

            // out: variables NEED NOT be initialized
            int employeeIdout;  
            bool isActiveout;
            string employeeNameout;

            GetEmployeeUsingOut(out employeeIdout, out isActiveout, out employeeNameout);

             Console.WriteLine("After out method call:");
            Console.WriteLine($"Employee Id   : {employeeIdout}");
            Console.WriteLine($"Is Active     : {isActiveout}");
            Console.WriteLine($"Employee Name : {employeeNameout}");
        }

        static void UpdateEmployeeDetails(out int empId,out bool status,out string name)
        {
            empId = 104;
            status = true;
            name = "Ravi";

            Console.WriteLine("Inside Method!!!");
            Console.WriteLine($"Employee Id : {empId}");
            Console.WriteLine($"Employee Status : {status}");
            Console.WriteLine($"Employee Name : {name}");
        }

         // ---------------- REF METHOD ----------------
        static void UpdateEmployeeUsingRef(ref int empId, ref bool status, ref string name)
        {
            // Using existing values and modifying them
            empId = 200;
            status = true;
            name = "John";
        }

        // ---------------- OUT METHOD ----------------
        static void GetEmployeeUsingOut(out int empId, out bool status, out string name)
        {
            // Must assign values before returning
            empId = 300;
            status = true;
            name = "Kumar";
        }

    }
}

#region
//In the ref example, the employee variables are already initialized in the Main method and then passed to UpdateEmployeeUsingRef. The method receives existing values, works on the same memory location, and updates them. Because of this, the updated values are immediately visible back in Main.

//In the out example, the employee variables are not initialized in the Main method. They are passed to GetEmployeeUsingOut, and the method itself is responsible for assigning values. The purpose here is not to update existing data, but to return fresh data back to the caller.

//The key difference is that ref is used to modify already available data, while out is used to supply data from a method. This is why ref needs initialization before the call, and out does not, but must be assigned inside the method.
#endregion
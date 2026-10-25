
using System;

namespace DebuggingTechniques
{
    class Program
    {
        static void Main()
        {
            string empDetails = getEmpNameByDesignation("John");

            Console.WriteLine(empDetails);
        }

        static string getJohnDetails()
        {
            string details = "John is a Software Engineer from UK";
            return details;
        }

        static string getLakshmiDetails()
        {
            string details = "Lakshmi is a Software Trainee from India";
            return details;
        }

        static string getEmpNameByDesignation(string empName)
        {
            string empDetails = "";
            string managerName = "Ram";

            if (empName == "John")
            {
                empDetails = getJohnDetails();
                empDetails = string.Concat(
                    empDetails, " John DOB is 12-Jan-1990"
                );
            }
            else if (empName == "Lakshmi")
            {
                empDetails = getLakshmiDetails();
                empDetails = string.Concat(
                    empDetails, " Lakshmi DOB is 23-Aug-2010"
                );
                empDetails = string.Concat(
                    empDetails, $" Manager name is {managerName}"
                );
            }
            else
            {
                empDetails = "No employee found";
            }

            return empDetails;
        }
    }
}

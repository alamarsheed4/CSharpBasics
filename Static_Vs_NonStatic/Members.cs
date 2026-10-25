using System;

namespace StaticAndNonStaticMembers{

    public static class Static_Logger{

        static int EmployeeList = 0;

        public static void LogMessage(string Message){
            Console.WriteLine($"[Log] {Message}");
            EmployeeList++;
        }
        ///<summary>
        /// Here We are going to get the total number of message 
        /// </summary>
        /// <return>int</returns>
        public static int GetMessageCount(){
            return EmployeeList;
        }
    }

    public class NonStatic_Logger{

        public int EmployeeList = 0;
        public void LogMessage(string Message){


             Console.WriteLine($"[Log] {Message}"); 
             EmployeeList++;
        }

        ///<summary>
        /// Here We are going to get the total number of message 
        /// </summary>
        /// <return>int</returns>
        public int GetMessageCount(){
            return EmployeeList;
        }
    }

    class Program{

        static void Main(){

            Static_Logger.LogMessage("Arsheed Has Join on Date 01-01-2026");
            Static_Logger.LogMessage("Nauman Has Join on Date 05-02-2026");

            int employeesCount = Static_Logger.GetMessageCount();
            Console.WriteLine($"Total Static Log Message Count: { employeesCount}");

            Console.WriteLine("***********This is for Non Static Class****************");

            NonStatic_Logger nonStatic_Logger = new NonStatic_Logger();

            nonStatic_Logger.LogMessage("Arsheed Has Join on Date 03-05-2026");

           int employeesCount1 =  nonStatic_Logger.GetMessageCount();

           Console.WriteLine($"Total Non Static Log Message Count :{employeesCount1} ");
           
            NonStatic_Logger nonStatic_Logger1 = new NonStatic_Logger();

            nonStatic_Logger1.LogMessage("Nauman Has Join on Date 06-07-2026");

           int employeesCount2 =  nonStatic_Logger1.GetMessageCount();

           Console.WriteLine($"Total Non Static Log Message Count :{employeesCount2} ");
        }
    }

}
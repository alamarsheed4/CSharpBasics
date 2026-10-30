using System;

namespace NamedParameter_Example
{
    class UserService
    {
        static void Main()
        {
            // Calling method using named parameters
            CreateUser(userName: "Ravi", role: "Admin", isActive: true);

            // Order does not matter when using named parameters
            CreateUser(isActive: false, userName: "Kumar", role: "User");

            AssignProject(projectName: "Nyayabharat", employeeName: "Ravi", durationInMonths: 6);
            ScheduleMeeting(time: "10 AM", topic: "Sprint Planning", organizer: "Madan");

        }

        static void CreateUser(string userName, string role, bool isActive)
        {
            Console.WriteLine($"User Name : {userName}");
            Console.WriteLine($"Role      : {role}");
            Console.WriteLine($"Is Active : {isActive}");
            Console.WriteLine("User created\n");
        }

        // Additional real-time methods using NAMED PARAMETERS

        static void AssignProject(string employeeName, string projectName, int durationInMonths)
        {
            Console.WriteLine($"Employee Name : {employeeName}");
            Console.WriteLine($"Project Name  : {projectName}");
            Console.WriteLine($"Duration      : {durationInMonths} Months");
            Console.WriteLine("Project assigned\n");
        }

        static void ScheduleMeeting(string topic, string organizer, string time)
        {
            Console.WriteLine($"Meeting Topic : {topic}");
            Console.WriteLine($"Organizer     : {organizer}");
            Console.WriteLine($"Time          : {time}");
            Console.WriteLine("Meeting scheduled\n");
        }

    }
}


#region  Explanation

//Program Explanation – Named Parameters

//This program demonstrates how named parameters work in real-time scenarios. Named parameters allow us to pass arguments to a method using parameter names, so the order of arguments does not matter, which improves readability and avoids confusion.

//1. CreateUser Method Explanation

//The CreateUser method creates a user with a name, role, and active status.
//In the Main method, arguments are passed using parameter names, so the order can be changed without affecting the output.
//This is useful in real-time applications like user management systems where clarity is more important than parameter order.

//2. AssignProject Method Explanation

//The AssignProject method assigns a project to an employee with a specific duration.
//Named parameters make the method call easy to understand, especially when multiple parameters are involved.
//This approach is commonly used in project allocation and HR systems.

//3. ScheduleMeeting Method Explanation

//The ScheduleMeeting method schedules a meeting with a topic, organizer, and time.
//Using named parameters makes the method call more readable and self-explanatory.
//It helps avoid mistakes when passing similar data types like strings.


#endregion
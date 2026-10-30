using System;

namespace OptionalParameter_Example
{
    class NotificationService
    {
        static void Main()
        {
            // Calling method without optional parameter
            SendNotification("Ravi","High");
            SendNotification("Arsheed");

            BookTicket("Arsheed","Side Lower",true);
            BookTicket("Raman","window");
            BookTicket("Sandeep");
        }

        static void SendNotification(string userName, string priority = "Normal")
        {
           Console.WriteLine($"User Name : {userName}");
           Console.WriteLine($"Priority : {priority}");
           Console.WriteLine($"Notification sent");

        }
        static void BookTicket(string passengerName, string seatType = "Regular", bool isMealRequired = false)
        {
            Console.WriteLine($"Passenger Name : {passengerName}");
            Console.WriteLine($"Seat Type : {seatType}");
            Console.WriteLine($"Meal Required : {isMealRequired}");
        }

    }
}
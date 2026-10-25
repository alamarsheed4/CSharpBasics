using System;
static class Logger{
    //field
    static string logFile = "application.txt";
    static string logFileDescription = "You have logged in the App At Mar-05-2026 at 3:00PM";

    //property
    static string LogFile {get; set;}

    //Constructor
    static Logger()
    {
        Logger.LogFile = "application2.txt";
    }

    static void LogMessage(string level , string message)
    {
        Console.WriteLine($"{DateTime.Now} [{level}] {message}");
    }

    static void LogInfo(string message)
    {
        LogMessage("INFO",message);
    }
    static void LogWarning(string message)
    {
        LogMessage("WARNING",message);
    }
    static void LogError(string message)
    {
        LogMessage("ERROR",message);
    }

    static void Main()
    {
        Console.WriteLine($"Log File name is {Logger.logFile}");
        Console.WriteLine($"Log File Description is {Logger.logFileDescription}");
        

        Console.WriteLine($"Log File property i.e {Logger.LogFile}");

        Logger.LogMessage("Basic", Logger.logFileDescription);
        Logger.LogInfo("Application Started!!");

        Logger.LogWarning("You have entered password three time after that your account will be locked!!");
        Logger.LogError("Something Went Wrong Please Try Again After Sometime!!");
        Logger.LogInfo("Application Has Stopped");
    }
}
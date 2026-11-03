//using DeveloperTasks;
using System;
using System.Threading;
using System.Threading.Tasks;


/*
    Here this Program is about Gives the Demo on Csharp
    1. WorkItems is the class which is used to prepare the documentation, PPTs and Notes.
    2. Trainer is the class which is used to call the WorkItems.
    3. In the Main method Trainer.Works() is called to perform the WorkItems.
    4. In the WorkItems class PrepareWordDocumentation, PreparePPTsPresentation and PrepareNotes are the methods which are used to download the files.
    5. Thread.Sleep is used to make the delay the time manually. Example 2000 means 2 seconds.
    6. Here Every method return type is void. So that we are not returning any value.(We will implement non-void methods in next example)
    7. The main goal of this program is to show the sequential order of the work items and how much time it will take to complete the work items.
 
 */



#region What is Synhronous call ?
/* What is Synchrous call ?
 * A : Synchronous call means that the program will wait for the method to complete before moving on to the next line of code.
*/
#endregion


namespace ConcurrencyProblem
{
    class TodoList
    {
        /// <summary>
        ///  Prepare the documentation
        /// </summary>
        public static Task FirstTask()
        {
            return Task.Run(() =>
            {
                //Task.Delay(5000);
                Console.WriteLine($"Task 1 completed");
            });

        }



        //Problem is here.
        //public static Task SecondTask()
        //{
        //    Task task = Task.Run(() =>
        //    {
        //        //Task.Delay(9000);
        //        Console.WriteLine($"Task 2 completed");
        //    });
        //    return task.Wait();
        //}

        public static Task ThirdTask()
        {

            Task task = Task.Run(() =>
            {
                //Task.Delay(4000);
                Console.WriteLine($"Task 3 completed");
            });
            return task;

        }


    }


    class Programs
    {
        static void Main()
        {
            TodoList.FirstTask();

           // TodoList.SecondTask();
            TodoList.ThirdTask();
        }
    }
}



/*Note*
 * Here i cannot say that wait asynchronously to second task for wait the third task
 */
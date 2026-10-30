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


namespace Tasks_Wait
{
    class WorkItems
    {
        /// <summary>
        ///  Prepare the documentation
        /// </summary>
        public static void PrepareWordDocumentation()
        {
            var startTime = DateTime.Now;

            //Here Prepare the documentation is taking the 2 seconds. Actually it will take 1 day but name saking i have taken 2 seconds : 🙂
            Thread.Sleep(2000);  // incase 2000 means 2 seconds

            // Record end time
            var endTime = DateTime.Now;
            // Calculate elapsed time
            var elapsedTime = endTime - startTime;

            Console.WriteLine($"Completed the Word Doucmentation Elapsed time (Task 1): {elapsedTime.TotalSeconds} Seconds.");
        }

        /// <summary>
        /// This method is used to download the Typescript file
        /// </summary>
        public static void PreparePPTsPresentation()
        {
            var startTime = DateTime.Now;
            //Here Prepare the PPTs is taking the 3 seconds. Actually it will take 1 day or 2 days but name saking i have taken 3 seconds : 🙂
            Thread.Sleep(9000);  // incase 3000 means 3 seconds

            //Task.Delay(1000).Wait()
            // Record end time
            var endTime = DateTime.Now;
            // Calculate elapsed time
            var elapsedTime = endTime - startTime;
            
            Console.WriteLine($"Completed the the PPTs Presentation (Task 2): {elapsedTime.TotalSeconds} Seconds.");
        }

        /// <summary>
        /// This method is used to download the HTML file
        /// </summary>
        public static void PrepareNotes()
        {
            var startTime = DateTime.Now;
            //Here Prepare the notes is taking the 4 seconds. Actually it will take 1 day or 2 days but name saking i have taken 4 seconds : 🙂
            Thread.Sleep(5000);  // incase 4000 means 4 seconds
            // Record end time
            var endTime = DateTime.Now;
            // Calculate elapsed time
            var elapsedTime = endTime - startTime;

            Console.WriteLine($"Completed the Notes (Task 3): {elapsedTime.TotalSeconds} Seconds.");
        }


    }

    class Trainer
    {
        public static void LetsStart()
        {
            /*****************For sequential order******************/
            //Console.WriteLine("Sequential Works - Step By Step");
            // Record start time for sequential downloading
            var preparationStartTime = DateTime.Now;

            //Ravi
            Task.Run(() => { WorkItems.PrepareWordDocumentation(); }).Wait();

            //Task task1 = Task.Run(()=>  { WorkItems.PrepareWordDocumentation();  });
            //task1.Wait();

            //Raghu
            Task.Run(() => { WorkItems.PreparePPTsPresentation(); }).Wait();
            //Task task2 = Task.Run(()=>  { WorkItems.PreparePPTsPresentation();  });
            //task1.Wait();

            //Ramu
            Task.Run(() => { WorkItems.PrepareNotes(); }).Wait();
            //Task task3 = Task.Run(()=>  { WorkItems.PrepareNotes();  });
            //task1.Wait();

            // Record end time for sequential downloading
            var preparationEndTime = DateTime.Now;
            // Calculate elapsed time for sequential downloading
            var sequentialElapsedTime = preparationEndTime - preparationStartTime;
            Console.WriteLine($"Completed Documentation.  Elapsed time: {sequentialElapsedTime.TotalSeconds} Seconds.");
        }


        /// <summary>
        /// Emergency Work of the trainer
        /// </summary>
        public static void EmergencyWork()
        {
            string trainerStatus = "Trainer is going outside for an emergency task";
            Console.WriteLine($"Trainer Status: {trainerStatus}");
        }

    }

    class Program
    {
        static void Main()
        {
            Trainer.LetsStart();
            Trainer.EmergencyWork();
            Console.ReadLine();
        }
    }
}



/*Note*
 *   Here in the above code Assigning the Each file download assigning to the one Task. So totally 3 tasks has created for handle the 3 files
 *   So that you got the time for less work.
 */
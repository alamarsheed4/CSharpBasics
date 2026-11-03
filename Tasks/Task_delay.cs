using System;
using System.Threading;
using System.Threading.Tasks;

/*PPT Available*/

namespace TasksExampleNamespace
{
    class FileDownloader
    {
        public void DownloadFileWithoutTask(string fileUrl)
        {
            Console.WriteLine($"Downloading file from {fileUrl} without Task.");
            // Record start time
            var startTime = DateTime.Now;

            // Simulate file downloading
            Thread.Sleep(2000);

            // Record end time
            var endTime = DateTime.Now;
            // Calculate elapsed time
            var elapsedTime = endTime - startTime;

            Console.WriteLine($"Download completed for {fileUrl}. Elapsed time: {elapsedTime.TotalMilliseconds} ms.");
        }

        public void DownloadFileWithTask(string fileUrl)
        {
            Console.WriteLine($"Downloading file from {fileUrl} with Task.");
            // Record start time
            var startTime = DateTime.Now;

            // Simulate file downloading asynchronously
            Task.Run(() =>
            {
                Thread.Sleep(2000);  // Means 2 seconds
                // Record end time
                var endTime = DateTime.Now;
                // Calculate elapsed time
                var elapsedTime = endTime - startTime;

                Console.WriteLine($"Download completed for {fileUrl}. Elapsed time: {elapsedTime.TotalMilliseconds} ms.");
            });
        }



        public void SequentialOrder()
        {
            string[] fileUrls = { "http://example.com/file1.txt", "http://example.com/file2.txt","http://example.com/file3.txt" };

            /*****************For sequential order******************/
            Console.WriteLine("Sequential Downloading:");
            // Record start time for sequential downloading
            var sequentialStartTime = DateTime.Now;
            foreach (var fileUrl in fileUrls)
            {
                DownloadFileWithoutTask(fileUrl);
            }
            // Record end time for sequential downloading
            var sequentialEndTime = DateTime.Now;
            // Calculate elapsed time for sequential downloading
            var sequentialElapsedTime = sequentialEndTime - sequentialStartTime;
            Console.WriteLine($"Sequential downloading completed. Total elapsed time: {sequentialElapsedTime.TotalMilliseconds} ms.");
        }


        public void OrderBasedonTask()
        {
            string[] fileUrls = { "http://example.com/file1.txt", "http://example.com/file2.txt", "http://example.com/file3.txt" };

            /******************************For based on the Tasks **********************/
            Console.WriteLine("\nDownloading with Tasks:");
            // Record start time for downloading with tasks
            var taskStartTime = DateTime.Now;

            foreach (var fileUrl in fileUrls)
            {
                DownloadFileWithTask(fileUrl);
            }
            // Record end time for downloading with tasks
            var taskEndTime = DateTime.Now;
            // Calculate elapsed time for downloading with tasks
            var taskElapsedTime = taskEndTime - taskStartTime;
            Console.WriteLine($"Downloading with tasks completed. Total elapsed time: {taskElapsedTime.TotalMilliseconds} ms.");

            // Keep console window open
            Console.ReadLine();
        }
    }

    class Program
    {
        static void Main()
        {

            FileDownloader fileDownloader = new FileDownloader();
            //fileDownloader.sequentialOrder();

            Console.WriteLine("***********************************************");

            fileDownloader.OrderBasedonTask();
            Console.ReadLine();

        }
    }
}



/*Note*
 *   Here in the above code Assigning the Each file download assigning to the one Task. So totally 3 tasks has created for handle the 3 files
 *   So that you got the time for less work.
 */
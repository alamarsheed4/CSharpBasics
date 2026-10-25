using System;
using ExcelFileSystem;
using PPTFileSystem;
using WordFileSystem;

namespace MainProgramSystem{

    class MainProgram{

        public static void Main()
        {

            Console.WriteLine("****************ExcelFileSystem************************");
            // ExcelFileSystem.Jan_ExcelFiles jan_ExcelFiles = new ExcelFileSystem.Jan_ExcelFiles();

            // Console.WriteLine(jan_ExcelFiles.FileName);
            
            Jan_ExcelFiles jan_ExcelFiles = new Jan_ExcelFiles();
            Console.WriteLine(jan_ExcelFiles.FileName);
           
            Feb_ExcelFiles feb_ExcelFiles = new Feb_ExcelFiles();
            Console.WriteLine(feb_ExcelFiles.FileName);
            
            Mar_ExcelFiles mar_ExcelFiles = new Mar_ExcelFiles();
            Console.WriteLine(mar_ExcelFiles.FileName);

            Console.WriteLine("****************PPTFileSystem************************");
        
            Jan_PPTFiles jan_PPTFiles = new Jan_PPTFiles();
            Console.WriteLine(jan_PPTFiles.FileName);

            Feb_PPTFiles feb_PPTFiles = new Feb_PPTFiles();
            Console.WriteLine(feb_PPTFiles.FileName);

            Mar_PPTFiles mar_PPTFiles = new Mar_PPTFiles();
            Console.WriteLine(mar_PPTFiles.FileName);

              Console.WriteLine("****************WordileSystem************************");
        
            Jan_WordFiles jan_WordFiles = new Jan_WordFiles();
            Console.WriteLine(jan_WordFiles.FileName);

            Feb_WordFiles feb_WordFiles = new Feb_WordFiles();
            Console.WriteLine(feb_WordFiles.FileName);

            Mar_WordFiles mar_WordFiles = new Mar_WordFiles();
            Console.WriteLine(mar_WordFiles.FileName);
        }
    }
}
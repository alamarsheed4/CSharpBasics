using System;

class FileDetailsConstructors
{
    string fileName = "Ram_resume.docx";
    string fileLocation = @"D:\Students\Resumes";
    string fileSize = "2kb";
    string createDate = "Mar-01-2026";

    DateTime createDateTime = DateTime.Now; 

    public FileDetailsConstructors()
    {
        Console.WriteLine("File Object Created!!");
        Console.WriteLine($"File Name : {this.fileName}");
        Console.WriteLine($"File Size : {this.fileSize}");
        Console.WriteLine($"File Location : {this.fileLocation}");
        Console.WriteLine($"Create Date : {this.createDate}");
        Console.WriteLine($"Create Date Time : {this.createDateTime}");

    }
    public FileDetailsConstructors( string fileName,string fileLocation,string fileSize, string createDate,DateTime createDateTime)
    {
        Console.WriteLine("File Object Created *********@2***********!!");
        Console.WriteLine($"File Name : {fileName}");
        Console.WriteLine($"File Size : {fileSize}");
        Console.WriteLine($"File Location : {fileLocation}");
        Console.WriteLine($"Create Date : {createDate}");
        Console.WriteLine($"Create Date Time : {createDateTime}");

    }

    static void Main(){
        FileDetailsConstructors fileDetailsConstructors = new FileDetailsConstructors();

        FileDetailsConstructors fileDetailsConstructors1 = new FileDetailsConstructors("Student_resume_docx",@"C:\File\Resumes_docx","4kb","April-03-1992",DateTime.Now);


    }
}
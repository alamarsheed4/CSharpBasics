using System;

namespace Methods_Advanced
{
    class Student
    {
        public string ? Name {get;set; }
        public  int ? Age {get; set;}
        public string ? Subject {get; set;}
    }

    class StudentOperations
    {
          /// <summary>
        /// Returns a single student as a class model.
        /// </summary>
         public static Student GetStudent()
        {
            return new Student
            {
                Name = "Peter",
                Age = 21,
                Subject = "JavaScript"
            };
        }

         /// <summary>
        /// Returns a list of students as class models.
        /// </summary>
        public static Student[] GetStudents()
        {
            return new Student[]
            {
                new Student { Name = "Peter", Age = 21, Subject = "JavaScript" },
                new Student { Name = "Mohan", Age = 22, Subject = "TypeScript" },
                new Student { Name = "Chandra", Age = 23, Subject = "HTML" }
            };
        }

         /// <summary>
        /// Takes a student as input and returns the same student with updated details.
        /// </summary>
        public static Student UpdateStudent(Student student)
        {
            student.Subject = student.Subject + " - Advanced"; // Update subject
            return student;
        }

        /// <summary>
        /// Takes a list of students as input and returns the updated list of students.
        /// </summary>
        public static Student[] UpdateStudents(Student[] students)
        {
            foreach (var student in students)
            {
                student.Subject  = student.Subject + " - Advanced"; // Update subject for each student
            }
            return students;
        }
    }
    class Program
    {
        public static void Main()
        {
          Student s1 =  StudentOperations.GetStudent();
          Console.WriteLine($"Student is : {s1.Name} , {s1.Age} , {s1.Subject}");
        
            Student[] students = StudentOperations.GetStudents();
            foreach(Student s in students)
            {
                Console.WriteLine($"Student is : {s.Name}, {s.Age}, {s.Subject}");

            }

           Student updatedStudentDetails =  StudentOperations.UpdateStudent(s1);
            Console.WriteLine($"Updated Student: {updatedStudentDetails.Name}, {updatedStudentDetails.Age}, {updatedStudentDetails.Subject}");
        }
    }
}
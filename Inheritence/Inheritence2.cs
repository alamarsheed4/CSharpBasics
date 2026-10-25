using System;

namespace family1{

    class Parent{
        public string ParenName{get; set;} = string.Empty;

        public void ShowParentMessage(){

            Console.WriteLine($"Hii , I am {ParenName} the Parent");
        }

        public Parent(string name, int Age){
            Console.WriteLine("This is Parent Class Constructor with Name and Age!!");
            Console.WriteLine($"Child Name i.e {name}");
            Console.WriteLine($"Child Age i.e {Age}");
        }

        public Parent(){
            Console.WriteLine("This is Parent Constructor without Parameter!!");
        }

    }

    class Child : Parent{

        public string ChildName{get; set;} = string.Empty;

        public void ShowChildMessage(){

            Console.WriteLine($"Hii, I am {this.ParenName}.. The Parent from Child");
            Console.WriteLine($"Hii, I am {this.ChildName}.. The Child from Child");
            
            //Console.WriteLine($"Hii, I am {base.ParenName}.. The Parent from Child");
            Console.WriteLine($"Hii , I am {ChildName} the Child");

            //or using creating instance

            var thisChild = this;

            Console.WriteLine("*********************using creating instance******************");

            Console.WriteLine($"Hii, I am {thisChild.ParenName}.. The Parent from Child");
            Console.WriteLine($"Hii, I am {thisChild.ChildName}.. The Child from Child");
            
        }

        public Child(string name, int Age){

            Console.WriteLine("This is Child Class Constructor!!");
        }

    }

    class Program{

        public static void Main(){

            Parent parent = new Parent("Jr. Arsheed", 19); // you can call this way also but only parent class members can be access

            parent.ShowParentMessage();

            
            // Child child = new Child("Jr. Arsheed", 19);

            // child.ChildName = "Jr. John";
            // child.ParenName = "Sr. John";

            // child.ShowChildMessage();
            // child.ShowParentMessage();

        }
    }
}